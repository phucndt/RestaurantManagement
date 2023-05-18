using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Models;

namespace MvcOrderItem.Data
{
    public class MvcOrderItemContext : DbContext
    {
        public MvcOrderItemContext (DbContextOptions<MvcOrderItemContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantManagement.Models.OrderItem> OrderItem { get; set; } = default!;
    }
}
