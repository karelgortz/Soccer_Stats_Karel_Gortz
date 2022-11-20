using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using Project_Karel_Gortz.Models;
using Project_Karel_Gortz.Models.Database;
using Project_Karel_Gortz.Models.ViewModels;
using Project_Karel_Gortz.Services;
using System.Diagnostics;

namespace Project_Karel_Gortz.Controllers
{
    public class HomeController : Controller
    {
        private readonly FixtureService _fixtureservice;
        private readonly TeamService _teamservice;

        public HomeController(FixtureService FixService, TeamService TeamService)
        {
            _fixtureservice = FixService;
            _teamservice = TeamService;
        }

        //Haalt alle wedstrijden op om weer te geven op de home-pagina 
        //Deze lijst wordt later opgedeeld in de meest recente wedsstrijden en meest recente wedstrijden van gevolgde teams
        public IActionResult Index()
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}