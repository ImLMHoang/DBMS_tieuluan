using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.NativeInterop;
using System.Configuration;
using Sign_in_and_Sign_Up.Model;

namespace Sign_in_and_Sign_Up
{
    internal class EFDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Showtime> Showtimes { get; set; }
        public DbSet<SeatBooking> SeatBookings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Đảm bảo rằng optionsBuilder chưa được cấu hình
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerID = 1,
                    FullName = "Default User",
                    PhoneNumber = 012345678,
                    Username = "Default",
                    Password = "Default"
                });
        }
    }
}
