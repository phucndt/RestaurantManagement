using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string IngredientName { get; set; }

        public int Quantity { get; set; }
    }
}
