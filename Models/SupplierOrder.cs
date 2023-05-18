using System;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.Models
{
    public class SupplierOrder
    {
        [Key]
        public int SupplierOrderId { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        [Required]
        public string IngredientName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
