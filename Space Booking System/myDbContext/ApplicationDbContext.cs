using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Space_Booking_System.Models;

namespace Space_Booking_System.myDbContext
{
    internal class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ENGABUFIRAS-PC;Initial Catalog=ReservationSystem;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
            .HasOne(b => b.Space)               // A booking has one space
            .WithMany(s => s.Bookings)           // A space has many bookings
            .HasForeignKey(b => b.SpaceID);
        }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Space> Spaces { get; set; }



    }
}
