using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JourneyPlatform.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; } 
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        [ForeignKey("RoleId")]

        public int RoleId { get; set; }
        public Roles Role { get; set; }

    }
}
