using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Models;

namespace MvcSupplierOrder.Data
{
    public class MvcSupplierOrderContext : DbContext
    {
        public MvcSupplierOrderContext (DbContextOptions<MvcSupplierOrderContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantManagement.Models.SupplierOrder> SupplierOrder { get; set; } = default!;
    }
}
