using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.ConfigurationModelBuilder;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<GuestBooking> GuestBookings { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = MUTLUTAYFUN; Initial Catalog = ReservasyonDB; Integrated Security = True; Trust Server Certificate = True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GuestBooking>()
                .HasKey(gb => new { gb.GuestId, gb.BookingId });

            modelBuilder.Entity<Staff>()
                .HasKey(s => new { s.HotelId });

            modelBuilder.Entity<Room>()
                .HasKey(r => new { r.HotelId, r.RoomTypeId });

            modelBuilder.Entity<Payment>()
               .HasKey(p => new { p.BookingId });

<<<<<<< HEAD
            modelBuilder.DefinedClasses();

=======
            modelBuilder.Entity<Room>()
                .HasOne(r => r.Hotel)
                .WithMany(h => h.Rooms)
                .HasForeignKey(r => r.HotelId);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Room)
                .WithMany()
                .HasForeignKey(b => new { b.RoomId, b.RoomTypeId }) // Foreign key yapılandırması
                .HasPrincipalKey(r => new { r.HotelId, r.RoomTypeId })
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GuestBooking>()
                .HasOne(gb => gb.Guest)
                .WithMany(g => g.GuestBookings)
                .HasForeignKey(gb => gb.GuestId);

            modelBuilder.Entity<GuestBooking>()
                .HasOne(gb => gb.Booking)
                .WithMany(b => b.GuestBookings)
                .HasForeignKey(gb => gb.BookingId);

            #region Bakılmalı!!
            //var hotelId = Guid.NewGuid();
            //var roomTypeId = Guid.NewGuid();
            //var roomId = Guid.NewGuid();
            //var guestId = Guid.NewGuid();
            //var bookingId = Guid.NewGuid();

            //modelBuilder.Entity<Hotel>().HasData(
            //    new Hotel
            //    {
            //        Id = hotelId,
            //        Name = "Grand Hotel",
            //        Address = "123 Main St",
            //        Phone = "1234567890",
            //        Email = "contact@grandhotel.com",
            //        Stars = 5,
            //        CheckinTime = DateTime.Now,
            //        CheckoutTime = DateTime.Now.AddHours(12)
            //    }
            //    );

            //modelBuilder.Entity<RoomType>().HasData(
            //    new RoomType
            //    {
            //        Id = roomTypeId,
            //        Name = "Suite",
            //        Description = "Luxurious Suite",
            //        PricePerNight = 250.00m,
            //        Capacity = 4
            //    }
            //    );

            //modelBuilder.Entity<Room>().HasData(
            //    new Room
            //    {
            //        Id = roomId,
            //        HotelId = hotelId,
            //        RoomTypeId = roomTypeId,
            //        Status = "Available"
            //    }
            //    );

            //modelBuilder.Entity<Guest>().HasData(
            //    new Guest
            //    {
            //        Id = guestId,
            //        FirstName = "John",
            //        LastName = "Doe",
            //        DateOfBirth = new DateTime(1990, 1, 1),
            //        Address = "456 Elm St",
            //        Phone = "0987654321",
            //        Email = "john.doe@example.com"
            //    }
            //    );
            #endregion


>>>>>>> ce1f04fe56774cfa2622e84042bd01c68d5a30c4
        }

    }
}
