using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace JourneyPlatform.Models.AccomodationModels
{
    public class Hostel
    {
        [Key]
        public int AccomodationId { get; set; }
        public string AccomodationTitle { get; set; }
        public string AccomodationDescription { get; set; }
        public string AccomodationCategory { get; set; }

        [ForeignKey("categoryId")]
        public int categoryId { get; set; }
        public AccomodationCategory category { get; set; }
    }
}