using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Models;

namespace MvcCustomer.Data
{
    public class MvcCustomerContext : DbContext
    {
        public MvcCustomerContext (DbContextOptions<MvcCustomerContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantManagement.Models.Customer> Customer { get; set; } = default!;
    }
}
