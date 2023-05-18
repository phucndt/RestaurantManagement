using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Models;

namespace MvcFeedback.Data
{
    public class MvcFeedbackContext : DbContext
    {
        public MvcFeedbackContext (DbContextOptions<MvcFeedbackContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantManagement.Models.Feedback> Feedback { get; set; } = default!;
    }
}
