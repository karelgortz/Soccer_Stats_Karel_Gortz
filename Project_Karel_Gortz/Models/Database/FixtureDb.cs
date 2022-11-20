using Project_Karel_Gortz.Models.Posts;
using System.ComponentModel.DataAnnotations;

namespace Project_Karel_Gortz.Models.Database
{
    public class FixtureDb
    {
        [Key]
        public int? Id { get; set; }
        public string? Referee { get; set; }
        public int? Season { get; set; }
        public string? Round { get; set; } //ronde dat gespeeld werd
        public string? Date { get; set; } //4 cijfers om het jaar van het seizoen aan te duiden (seizoen 2021-2022 wordt dus 2021)
        public int? Timestamp { get; set; }
        public int? HomeGoals { get; set; }
        public int? Awaygoals { get; set; }
        //public List<TeamDb> Teams { get; set; }

        //public TeamDb? HomeTeam { get; set; }
        public int? HomeTeamId { get; set; }
        //public TeamDb? AwayTeam { get; set; }
        public int? AwayTeamId { get; set; }
        public VenueDb? Venue { get; set; }
        public int? VenueId { get; set; }
        public LeagueDb? League { get; set; }
        public int? LeagueId { get; set; }


        public ICollection<TeamDb>? TeamDbs { get; set; }
        public ICollection<Post>? Posts { get; set; }

    }
}
