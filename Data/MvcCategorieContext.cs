using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Models;

namespace MvcCategorie.Data
{
    public class MvcCategorieContext : DbContext
    {
        public MvcCategorieContext (DbContextOptions<MvcCategorieContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantManagement.Models.Category> Category { get; set; } = default!;
    }
}
