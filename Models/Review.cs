using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int MenuItemId { get; set; }
        public Menu MenuItem { get; set; }

        public int Rating { get; set; }

        public string Comment { get; set; }
    }
}
