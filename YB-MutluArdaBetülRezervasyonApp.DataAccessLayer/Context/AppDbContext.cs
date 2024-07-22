using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

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

            // İlişkileri ve diğer yapılandırmaları tanımlıyoruz

            modelBuilder.Entity<Room>()
                .HasOne(r => r.Hotel)
                .WithMany(h => h.Rooms)
                .HasForeignKey(r => r.HotelId);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Room)
                .WithMany()
                .HasForeignKey(b => b.RoomId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GuestBooking>()
                .HasOne(gb => gb.Guest)
                .WithMany(g => g.GuestBookings)  // Public özelliğe erişim
                .HasForeignKey(gb => gb.GuestId);

            modelBuilder.Entity<GuestBooking>()
                .HasOne(gb => gb.Booking)
                .WithMany(b => b.GuestBookings)
                .HasForeignKey(gb => gb.BookingId);


            
        }
        
    }
}
