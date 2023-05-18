using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Models;

namespace MvcReview.Data
{
    public class MvcReviewContext : DbContext
    {
        public MvcReviewContext (DbContextOptions<MvcReviewContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantManagement.Models.Review> Review { get; set; } = default!;
    }
}
