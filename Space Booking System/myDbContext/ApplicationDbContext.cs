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
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Space> Spaces { get; set; }



    }
}
