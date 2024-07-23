using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories
{
    public class GuestBookingRepository : GenericRepository<GuestBooking>
    {
        public GuestBookingRepository(AppDbContext context) : base(context)
        {
        }
    }
}
