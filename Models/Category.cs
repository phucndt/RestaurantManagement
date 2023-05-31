using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.Models
{
    public class Category
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}
