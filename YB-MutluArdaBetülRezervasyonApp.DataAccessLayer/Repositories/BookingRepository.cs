using Microsoft.EntityFrameworkCore;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories
{
    public class BookingRepository : GenericRepository<Booking>
    {
        private readonly AppDbContext _context;
        public BookingRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public IEnumerable<Booking> GetBookingsWithGuests()
        {
            return _context.Bookings
                           .Include(b => b.GuestBookings)
                           .ThenInclude(gb => gb.Guest)
                           .ToList();
        }
        public IEnumerable<Booking> GetDetailedBookings()
        {
            return _context.Bookings
                           .Include(b => b.GuestBookings)
                               .ThenInclude(gb => gb.Guest)
                           .Include(b => b.Room)
                               .ThenInclude(r => r.RoomType)
                           .Include(b => b.Room)
                               .ThenInclude(r => r.Hotel)
                           .ToList();
        }
    }
}
