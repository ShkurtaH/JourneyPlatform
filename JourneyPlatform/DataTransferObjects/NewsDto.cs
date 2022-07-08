using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JourneyPlatform.DataTransferObjects
{
    public class NewsDto
    {
        [Key]
        public int NewsId { get; set; }
        public string NewsTitle { get; set; }
        public string NewsDescription { get; set; }
        public string NewsCategory { get; set; }
        public string DataOfPosting { get; set; }

        [ForeignKey("categoryId")]
        public int categoryId { get; set; }
    }
}
