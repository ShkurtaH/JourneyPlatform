
using System.ComponentModel.DataAnnotations;

namespace JourneyPlatform.Models
{
    public class Navigation
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Link { get; set; } 
        public string? FeaturedImage { get; set; } 

    }
}