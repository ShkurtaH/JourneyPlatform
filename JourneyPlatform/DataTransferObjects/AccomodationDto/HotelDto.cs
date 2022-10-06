using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JourneyPlatform.Dtos.AccomodationDto
{
    public class InsertHotelDto
    {
        [Key]
        public int AccomodationId { get; set; }
        public string AccomodationTitle { get; set; }
        public string AccomodationDescription { get; set; }
        public string AccomodationCategory { get; set; }

        [ForeignKey("categoryId")]
        public int categoryId { get; set; }
    }
}