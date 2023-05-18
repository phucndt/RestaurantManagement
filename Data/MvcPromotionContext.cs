using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Models;

namespace MvcPromotion.Data
{
    public class MvcPromotionContext : DbContext
    {
        public MvcPromotionContext (DbContextOptions<MvcPromotionContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantManagement.Models.Promotion> Promotion { get; set; } = default!;
    }
}
