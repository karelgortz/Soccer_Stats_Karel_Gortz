using System.ComponentModel.DataAnnotations;

namespace Project_Karel_Gortz.Models.Database
{
    public class VenueDb
    {
        [Key]
        public int Id { get; set; }
        public int? VenueId { get; set;}
        public string? Name { get; set; }
        public string? City { get; set; }

        //public FixtureDb? Fixture { get; set; }
        public ICollection<FixtureDb>? FixtureDbs { get; set; }
    }
}
