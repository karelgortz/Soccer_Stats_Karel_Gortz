using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Project_Karel_Gortz.Data;
using Project_Karel_Gortz.Models.Database;
using Project_Karel_Gortz.Models.ModelBinding;
using Project_Karel_Gortz.Models.Posts;
using Project_Karel_Gortz.Models.Stats;
using Project_Karel_Gortz.Models.Users;
using Project_Karel_Gortz.Models.ViewModels;
using Project_Karel_Gortz.Services;

namespace Project_Karel_Gortz.Controllers
{
    [Authorize]
    public class FixtureController : Controller
    {
        private readonly FixtureService _fixtureservice;
        private readonly TeamService _teamservice;
        private readonly PostService _postservice;
        private readonly CommentService _commentservice;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<CustomUser> _userManager;

        public FixtureController(FixtureService fixService, TeamService teamService, ApplicationDbContext applicationDbContext, UserManager<CustomUser> user, PostService postService, CommentService commentService)
        {
            _fixtureservice = fixService;
            _teamservice = teamService;
            _context = applicationDbContext;
            _userManager = user;
            _postservice = postService;
            _commentservice = commentService;
        }

        //Haalt een lijst op van alle beschikbare matchen
        [AllowAnonymous]
        public IActionResult All()
        {
            List<FixtureDb> fixtures = _fixtureservice.GetAllFixtures();
            List<TeamDb> teams = _teamservice.GetAllTeams();

            List<FixtureViewModel> fixturelist = new List<FixtureViewModel>();
            foreach (FixtureDb item in fixtures)
            {
                TeamDb hometeam = teams.Where(x => x.Id == item.HomeTeamId).SingleOrDefault();
                TeamDb awayteam = teams.Where(x => x.Id == item.AwayTeamId).SingleOrDefault();
                FixtureViewModel vm = new FixtureViewModel()
                {
                    Id = item.Id,
                    Referee = item.Referee,
                    Season = item.Season,
                    Round = item.Round,
                    Date = item.Date,
                    Timestamp = item.Timestamp,
                    HomeGoals = item.HomeGoals,
                    Awaygoals = item.Awaygoals,
                    Hometeam = hometeam,
                    Awayteam = awayteam,
                    Venue = item.Venue,
                    League = item.League
                };
                fixturelist.Add(vm);
            }
            return View(fixturelist);
        }

        //Ophalen statistieken van het geselecteerde fixture
        //Ik heb ervoor gekozen om deze statistieken-data niet in mijn databank op te slaan zodat het niet te veel ruimte in neemt.
        //Ik zou dit wel kunnen doen zoals ik dat bij Fixtures heb gedaan.
        [AllowAnonymous]
        public IActionResult Details(int fixId)
        {
            FixtureDb fixture = _context.Fixtures.Find(fixId);
            LeagueDb league = _context.Leagues.Find(fixture.LeagueId);
            VenueDb venue = _context.Venues.Find(fixture.VenueId);
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "api-football-v1.p.rapidapi.com");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "");
            var response = client.GetStringAsync($"https://api-football-v1.p.rapidapi.com/v3/fixtures/statistics?fixture={fixture.Id}");
            var responseBody = response.Result;
            TotalStatisticsResponse jsonresponse = JsonConvert.DeserializeObject<TotalStatisticsResponse>(responseBody);

            List<Stat> home = jsonresponse.Response[0].Statistics;
            List<Stat> away = jsonresponse.Response[1].Statistics;

            List<Post> posts = _context.Posts.Include(x => x.Author).Include(x => x.Comments).ThenInclude(x => x.Author).Where(x => x.FixtureId == fixId).ToList();

            
            
            TeamDb hometeam = _context.Teams.Find(fixture.HomeTeamId);
            TeamDb awayteam = _context.Teams.Find(fixture.AwayTeamId);
            FixtureDetailsViewModel vm = new FixtureDetailsViewModel()
            {
                Id = fixture.Id,
                Referee = fixture.Referee,
                Season = fixture.Season,
                Round = fixture.Round,
                Date = fixture.Date,
                Timestamp = fixture.Timestamp,
                HomeGoals = fixture.HomeGoals,
                Awaygoals = fixture.Awaygoals,
                Hometeam = hometeam,
                Awayteam = awayteam,
                Venue = venue,
                League = league,
                Homestats = home,
                Awaystats = away,
                Posts = posts
            };
            return View(vm);
        }

        //
        //Bij dit project bestaat een een verschil tussen posts en comments. Posts kunnen geplaatst worden onder fixtures. Comments worden geplaatst onder een Post. 
        //Het is vergelijkbaar met Youtube of Reddit comments waar er "hoofd"posts zijn met daaronder comments.
        //

        //POSTS

        //Aanmaken van een post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePostAsync(PostBindingModel model)
        {
            if (ModelState.IsValid)
            {
                Post post = new Post()
                {
                    FixtureId = model.FixtureId,
                    Title = model.Title,
                    Content = model.Content,
                    TimeStamp = DateTime.Now,
                    Author = await _userManager.GetUserAsync(HttpContext.User)
                };

                _context.Posts.Add(post);
                _context.SaveChanges();
                return RedirectToAction("Details", new { fixId = (int)model.FixtureId});
            }
            return RedirectToAction("Details", new { fixId = (int)model.FixtureId }); 
        }

        //Verwijderen van een post
        //Dit kan gedaan worden door een admin of door de persoon die de post heeft aangemaakt
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int postId, int fixId)
        {
            _postservice.DeletePost(postId);
            return RedirectToAction("Details", new { fixId = fixId });
        }

        //Wijzigen van een post
        //Dit kan enkel gedaan worden door de persoon die de posst heeft aangemaakt
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPost(PostBindingModel model)
        {
            if (ModelState.IsValid)
            {
                _postservice.EditPost(model);
                return RedirectToAction("Details", new { fixId = model.FixtureId });
            }
            return RedirectToAction("Details", new { fixId = model.FixtureId });
        }

        //COMMENTS

        //Aanmaken van een comment
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCommentAsync(CommentBindingModel model)
        {
            if (ModelState.IsValid)
            {
                Comment comment = new Comment()
                {
                    Content = model.Content,
                    TimeStamp = DateTime.Now,
                    Author = await _userManager.GetUserAsync(HttpContext.User),
                    PostId = model.PostId
                };

                _context.Comments.Add(comment);
                _context.SaveChanges();
                return RedirectToAction("Details", new { fixId = (int)model.FixtureId });
            }
            return RedirectToAction("Details", new { fixId = (int)model.FixtureId });
        }
        
        //Verwijderen van een comment
        //Net zoals bij posts kan dit alleen door een admin of door de oorspronkelijke commenter gedaan worden.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteComment(int commentId, int fixId)
        {
            _commentservice.DeleteComment(commentId);
            return RedirectToAction("Details", new { fixId = fixId });
        }

        //Wijzigen van een comment
        //Kan alleen gedaan worden door de originele commenter
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditComment(CommentBindingModel model)
        {
            if (ModelState.IsValid)
            {
                _commentservice.EditComment(model);
                return RedirectToAction("Details", new { fixId = model.FixtureId });
            }

            return RedirectToAction("Details", new { fixId = model.FixtureId });
        }
    }
}
