using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.Models
{
    public class Menu
    {
        [Key]
        public int MenuItemId { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public bool IsAvailable { get; set; }
    }
}
