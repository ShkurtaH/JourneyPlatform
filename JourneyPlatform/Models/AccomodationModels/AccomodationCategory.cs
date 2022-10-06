using System.ComponentModel.DataAnnotations;

namespace JourneyPlatform.Models.AccomodationModels

{
    public class AccomodationCategory
    {
        [Key]
        public string CategoryId { get; set; }

        public int CategoryTitle { get; set; }
    }
}