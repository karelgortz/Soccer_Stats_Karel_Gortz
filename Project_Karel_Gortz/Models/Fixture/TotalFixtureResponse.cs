namespace Project_Karel_Gortz.Models
{
    public class TotalFixtureResponse
    {
        public string? Get { get; set; } 
        public FixtureParameters? Parameters { get; set; }
        public string[]? Errors { get; set; }
        public int? Results { get; set; }
        public Paging? Paging { get; set; }
        public List<FixtureResponse>? Response { get; set; }
    }
}
