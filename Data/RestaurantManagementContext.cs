using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Models;

    public class RestaurantManagementContext : DbContext
    {
        public RestaurantManagementContext (DbContextOptions<RestaurantManagementContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantManagement.Models.Customer> Customer { get; set; } = default!;

        public DbSet<RestaurantManagement.Models.Category> Category { get; set; } = default!;

        public DbSet<RestaurantManagement.Models.Feedback> Feedback { get; set; } = default!;

        public DbSet<RestaurantManagement.Models.Inventory> Inventory { get; set; } = default!;

        public DbSet<RestaurantManagement.Models.Menu> Menu { get; set; } = default!;

        public DbSet<RestaurantManagement.Models.Order> Order { get; set; } = default!;

        public DbSet<RestaurantManagement.Models.OrderItem> OrderItem { get; set; } = default!;

        public DbSet<RestaurantManagement.Models.Promotion> Promotion { get; set; } = default!;

        public DbSet<RestaurantManagement.Models.Review> Review { get; set; } = default!;

        public DbSet<RestaurantManagement.Models.Role> Role { get; set; } = default!;

        public DbSet<RestaurantManagement.Models.Supplier> Supplier { get; set; } = default!;

        public DbSet<RestaurantManagement.Models.SupplierOrder> SupplierOrder { get; set; } = default!;

        public DbSet<RestaurantManagement.Models.TableReservation> TableReservation { get; set; } = default!;

        public DbSet<RestaurantManagement.Models.User> User { get; set; } = default!;
    }
