using System.ComponentModel.DataAnnotations;

namespace Project_Karel_Gortz.Models.Database
{
    public class TeamDb
    {
        [Key]
        public int Id { get; set; }
        public int? TeamId { get; set; }
        public string? Name { get; set; }
        public string? Logo { get; set; } //imageurl

        public FixtureDb? Fixture { get; set; }
        public int? Fixtureid { get; set; }
    }
}
