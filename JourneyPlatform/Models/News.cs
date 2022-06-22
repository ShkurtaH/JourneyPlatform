using System.Text.Json.Serialization;

namespace JourneyPlatform.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Date { get; set; }
    }
}