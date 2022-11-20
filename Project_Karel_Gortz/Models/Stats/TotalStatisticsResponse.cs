namespace Project_Karel_Gortz.Models.Stats
{
    public class TotalStatisticsResponse
    {
        public string? Get { get; set; }
        public StatisticsParameters? Parameters { get; set; }
        public string[]? Errors { get; set; }
        public int? Results { get; set; }
        public Paging? Paging { get; set; }
        public List<StatisticsResponse> Response { get; set; }
    }
}
