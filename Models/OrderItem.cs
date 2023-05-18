using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int MenuItemId { get; set; }
        public Menu MenuItem { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
