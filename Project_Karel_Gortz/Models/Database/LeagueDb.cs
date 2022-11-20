using System.ComponentModel.DataAnnotations;

namespace Project_Karel_Gortz.Models.Database
{
    public class LeagueDb
    {
        [Key]
        public int Id { get; set; }
        public int? LeagueId { get; set; }
        public string? Name { get; set; }
        public string? Country { get; set; }
        public string? Logo { get; set; } //imageurl
        public string? Flag { get; set; } //imageurl

        public ICollection<FixtureDb>? FixtureDbs { get; set; }

        //public FixtureDb? Fixture { get; set; }

    }
}
