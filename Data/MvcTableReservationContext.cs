using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Models;

namespace MvcTableReservation.Data
{
    public class MvcTableReservationContext : DbContext
    {
        public MvcTableReservationContext (DbContextOptions<MvcTableReservationContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantManagement.Models.TableReservation> TableReservation { get; set; } = default!;
    }
}
