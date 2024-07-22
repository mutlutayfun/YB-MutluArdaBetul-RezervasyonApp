using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories
{
    public class IGuestBookingRepository : IGenericRepository<GuestBooking>
    {
        public IGuestBookingRepository(AppDbContext context) : base(context)
        {
        }
    }
}
