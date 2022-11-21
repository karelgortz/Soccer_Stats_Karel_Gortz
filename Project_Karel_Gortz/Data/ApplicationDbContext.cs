
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Project_Karel_Gortz.Models;
using Project_Karel_Gortz.Models.Database;
using Project_Karel_Gortz.Models.Posts;
using Project_Karel_Gortz.Models.Users;
using System.Security.Claims;

namespace Project_Karel_Gortz.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Hier maak ik gebruik van de Football-API om data over voetbalwedstrijden op te slaan in mijn databank.
        //Ik heb als competitie de Bundesliga gekozen omdat mijn favoriete team hier speelt en zodat ik niet te veel data in mijn databank heb zitten.

        //De klassen in de "Fixture" en "Stats" klassen worden gebruikt om de data van de API correct op te halen. 
        //Daarna steek ik die opgehaalde data in de klassen van de "Database" om effectief mijn databank mee te maken.
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "api-football-v1.p.rapidapi.com");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "");
            var response = client.GetStringAsync("https://api-football-v1.p.rapidapi.com/v3/fixtures?league=78&season=2021");
            var responseBody = response.Result;
            TotalFixtureResponse jsonresponse = JsonConvert.DeserializeObject<TotalFixtureResponse>(responseBody);
            List<FixtureDb> fixtures = new List<FixtureDb>();
            List<VenueDb> venues = new List<VenueDb>();
            List<TeamDb> teams = new List<TeamDb>();
            List<LeagueDb> leagues = new List<LeagueDb>();
            List<Post> posts = new List<Post>();
            List<Comment> comments = new List<Comment>();
            int count = 1;
            int teamcount = 1;
            foreach (var item in jsonresponse.Response)
            {
                VenueDb Venue = new VenueDb()
                {
                    Id = count,
                    VenueId = item.Fixture.Venue.Id,
                    Name = item.Fixture.Venue.Name,
                    City = item.Fixture.Venue.City
                };
                LeagueDb League = new LeagueDb()
                {
                    Id = count,
                    LeagueId = item.League.Id,
                    Name = item.League.Name,
                    Country = item.League.Country,
                    Flag = item.League.Flag,
                    Logo = item.League.Logo
                };
                TeamDb HomeTeam = new TeamDb()
                {
                    Id = teamcount,
                    TeamId = item.Teams.Home.Id,
                    Name = item.Teams.Home.Name,
                    Logo = item.Teams.Home.Logo

                };
                TeamDb AwayTeam = new TeamDb()
                {
                    Id = teamcount + 1,
                    TeamId = item.Teams.Away.Id,
                    Name = item.Teams.Away.Name,
                    Logo = item.Teams.Away.Logo
                };
                FixtureDb fixture = new FixtureDb()
                {
                    Id = item.Fixture.Id,
                    Referee = item.Fixture.Referee,
                    Season = item.League.Season,
                    Round = item.League.Round,
                    Date = item.Fixture.Date,
                    Timestamp = item.Fixture.Timestamp,
                    HomeGoals = item.Goals.Home,
                    HomeTeamId = HomeTeam.Id,
                    AwayTeamId = AwayTeam.Id,
                    Awaygoals = item.Goals.Away,
                    LeagueId = League.Id,
                    VenueId = Venue.Id
                };

                fixtures.Add(fixture);
                if (!venues.Contains(Venue))
                {
                    venues.Add(Venue);
                }
                if (!leagues.Contains(League))
                {
                    leagues.Add(League);
                }
                if (!teams.Contains(HomeTeam))
                {
                    teams.Add(HomeTeam);
                }
                if (!teams.Contains(AwayTeam))
                {
                    teams.Add(AwayTeam);
                }
                count++;
                teamcount = teamcount + 2;
            }
            builder.Entity<FixtureDb>().HasData(fixtures);
            builder.Entity<VenueDb>().HasData(venues);
            builder.Entity<LeagueDb>().HasData(leagues);
            builder.Entity<TeamDb>().HasData(teams);
        }
        public DbSet<FixtureDb> Fixtures { get; set; }
        public DbSet<LeagueDb> Leagues { get; set; }
        public DbSet<VenueDb> Venues { get; set; }
        public DbSet<TeamDb> Teams { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

       
    }

}
