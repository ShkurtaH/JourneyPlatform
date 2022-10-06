using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JourneyPlatform.DataTransferObjects
{
    public class NavigationDto
    {
        [Key]
        public int Id{ get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string FeaturedImage { get; set; }

        [ForeignKey("categoryId")]
        public int categoryId { get; set; }
    }
}