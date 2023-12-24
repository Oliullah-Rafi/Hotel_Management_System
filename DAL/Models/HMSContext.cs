using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   internal class HMSContext :DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Staff> Staffs { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<RoomType> RoomTypes { get; set; }

        public DbSet<Guest> Guests { get; set; }

    }
}
