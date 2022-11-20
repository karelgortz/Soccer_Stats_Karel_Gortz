using Newtonsoft.Json;
using System.Globalization;

namespace Project_Karel_Gortz.Models
{
    public class FixtureParameters
    {
        public int? League { get; set; }
        public string? Season { get; set; }
        //public int? Team { get; set; } //Enkel actief als je van een secifiek team wedstrijden wil zien
      
    }
}
