using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
