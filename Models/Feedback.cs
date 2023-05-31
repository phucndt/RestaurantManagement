using System;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FeedbackDate { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
