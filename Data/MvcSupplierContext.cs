using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Models;

namespace MvcSupplier.Data
{
    public class MvcSupplierContext : DbContext
    {
        public MvcSupplierContext (DbContextOptions<MvcSupplierContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantManagement.Models.Supplier> Supplier { get; set; } = default!;
    }
}
