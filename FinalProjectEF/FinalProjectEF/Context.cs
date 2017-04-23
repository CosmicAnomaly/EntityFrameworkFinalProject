using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Scott Robinson
 * .Net Final Project
 * Spring 2017
 */

namespace FinalProjectEF
{
    class Context : DbContext
    {
        public Context()
            : base ("name=FinalProjectEF.Properties.Settings.HotelDatabaseConnectionString")
        {
            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
        }

        public DbSet<Room> HotelRooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
