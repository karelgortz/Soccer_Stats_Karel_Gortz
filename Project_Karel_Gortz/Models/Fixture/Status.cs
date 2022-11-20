namespace Project_Karel_Gortz.Models
{
    public class Status
    {
        public string? Long { get; set; } //Volledig geschreven (bv "Halftime")
        public string? Short { get; set; } //Afgekort (bv "HT")
        public int? Elapsed { get; set; } //Aantal minuten die gespeeld zijn

    }
}
