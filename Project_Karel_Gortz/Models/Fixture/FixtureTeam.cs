namespace Project_Karel_Gortz.Models
{
    public class FixtureTeam
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Logo { get; set; } //imageurl
        public bool? Winner { get; set; } //Duidt aan of dit team het fixture gewonnen is
    }
}
