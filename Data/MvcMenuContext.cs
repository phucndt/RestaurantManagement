using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Models;

namespace MvcMenu.Data
{
    public class MvcMenuContext : DbContext
    {
        public MvcMenuContext (DbContextOptions<MvcMenuContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantManagement.Models.Menu> Menu { get; set; } = default!;
    }
}
