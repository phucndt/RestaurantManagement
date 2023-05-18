using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Models;

namespace MvcOrder.Data
{
    public class MvcOrderContext : DbContext
    {
        public MvcOrderContext (DbContextOptions<MvcOrderContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantManagement.Models.Order> Order { get; set; } = default!;
    }
}
