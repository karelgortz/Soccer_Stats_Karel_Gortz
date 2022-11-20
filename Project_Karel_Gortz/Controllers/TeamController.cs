using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project_Karel_Gortz.Data;
using Project_Karel_Gortz.Models.Database;
using Project_Karel_Gortz.Models.Users;
using Project_Karel_Gortz.Models.ViewModels;
using Project_Karel_Gortz.Services;

namespace Project_Karel_Gortz.Controllers
{
    public class TeamController : Controller
    {
        private readonly TeamService _teamservice;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<CustomUser> _userManager;
        private readonly FixtureService _fixtureservice;
        public TeamController(FixtureService FixService, TeamService teamService, ApplicationDbContext applicationDbContext, UserManager<CustomUser> user)
        {
            _fixtureservice = FixService;
            _teamservice = teamService;
            _context = applicationDbContext;
            _userManager = user;

        }

        //Laadt een lijst in met alle teams
        public IActionResult Index()
        {
            List<TeamDb> teams = _teamservice.GetAllTeams();
            teams = teams.DistinctBy(x => x.TeamId).ToList();
            List<TeamViewModel> vmlist = new List<TeamViewModel>();
            foreach (var item in teams)
            {
                TeamViewModel vm = new TeamViewModel()
                {
                    Name = item.Name,
                    Logo = item.Logo,
                    TeamId = item.TeamId
                };
                vmlist.Add(vm);
            }
            return View(vmlist);
        }

        //Laat de 5 laatste wedstrijden van een aangeklikt team zien. 
        public IActionResult LatestGames(int teamId)
        {
            List<FixtureDb> fixtures = _fixtureservice.GetAllFixtures();
            List<TeamDb> teams = _teamservice.GetAllTeams().Where(x => x.TeamId == teamId).ToList();
            List<FixtureDb> recentlist = new List<FixtureDb>();
            foreach (var item in teams)
            {
                recentlist.Add(fixtures.Where(x => x.AwayTeamId == item.Id || x.HomeTeamId == item.Id).ToList()[0]);
            }
            recentlist = recentlist.GetRange(recentlist.Count() - 5, 5);
            List<TeamDb> allteams = _teamservice.GetAllTeams();

            List<FixtureViewModel> fixturelist = new List<FixtureViewModel>();
            foreach (FixtureDb item in recentlist)
            {
                TeamDb hometeam = allteams.Where(x => x.Id == item.HomeTeamId).SingleOrDefault();
                TeamDb awayteam = allteams.Where(x => x.Id == item.AwayTeamId).SingleOrDefault();
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
    }
}
