using System.ComponentModel.DataAnnotations;

namespace JouneyPlatform.Models
{
    public class Accomodation
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string category { get; set; }

    }
}