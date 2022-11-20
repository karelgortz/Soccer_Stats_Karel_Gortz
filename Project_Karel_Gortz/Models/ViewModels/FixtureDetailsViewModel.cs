using Project_Karel_Gortz.Models.Database;
using Project_Karel_Gortz.Models.ModelBinding;
using Project_Karel_Gortz.Models.Posts;
using Project_Karel_Gortz.Models.Stats;

namespace Project_Karel_Gortz.Models.ViewModels
{
    public class FixtureDetailsViewModel
    {
        public int? Id { get; set; }
        public string? Referee { get; set; }
        public int? Season { get; set; }
        public string? Round { get; set; } //ronde dat gespeeld werd
        public string? Date { get; set; } //4 cijfers om het jaar van het seizoen aan te duiden (seizoen 2021-2022 wordt dus 2021)
        public int? Timestamp { get; set; }
        public int? HomeGoals { get; set; }
        public int? Awaygoals { get; set; }
        public TeamDb? Hometeam { get; set; }
        public TeamDb? Awayteam { get; set; }
        public VenueDb? Venue { get; set; }
        public LeagueDb? League { get; set; }
        public List<Stat>? Homestats { get; set; }
        public List<Stat>? Awaystats { get; set; }
        public List<Post>? Posts { get; set; }
    }
}
