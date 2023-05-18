using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Models;

namespace MvcInventorie.Data
{
    public class MvcInventorieContext : DbContext
    {
        public MvcInventorieContext (DbContextOptions<MvcInventorieContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantManagement.Models.Inventory> Inventory { get; set; } = default!;
    }
}
