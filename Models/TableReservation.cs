using System;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.Models
{
    public class TableReservation
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        public int TableNumber { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ReservationDateTime { get; set; }
    }
}
