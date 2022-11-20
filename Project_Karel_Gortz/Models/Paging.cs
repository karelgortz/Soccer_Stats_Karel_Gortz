namespace Project_Karel_Gortz.Models
{
    //Deze klasse is nodig om de data correct te kunnen ophalen uit de API.
    public class Paging
    {
        public int? Current { get; set; }
        public int? Total { get; set; }
    }
}
