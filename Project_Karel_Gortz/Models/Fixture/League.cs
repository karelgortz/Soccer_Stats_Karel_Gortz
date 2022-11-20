namespace Project_Karel_Gortz.Models
{
    public class League
    {
		public int? Id { get; set; }
		public string? Name { get; set; }
		public string? Country { get; set; }
		public string? Logo { get; set; } //imageurl
		public string? Flag { get; set; } //imageurl
		public int? Season { get; set; } //4 cijfers om het jaar van het seizoen aan te duiden (seizoen 2021-2022 wordt dus 2021)
		public string Round { get; set; } //ronde dat gespeeld werd
	}
}
