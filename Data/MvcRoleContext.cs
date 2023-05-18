using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Models;

namespace MvcRole.Data
{
    public class MvcRoleContext : DbContext
    {
        public MvcRoleContext (DbContextOptions<MvcRoleContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantManagement.Models.Role> Role { get; set; } = default!;
    }
}
