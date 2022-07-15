
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.Models
{
    public class Roles
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}