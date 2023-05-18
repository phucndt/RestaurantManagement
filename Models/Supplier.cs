using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Required]
        public string SupplierName { get; set; }
    }
}
