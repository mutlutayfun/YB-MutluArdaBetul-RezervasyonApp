using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories
{
    public class IBookingRepository : IGenericRepository<Booking>
    {
        public IBookingRepository(AppDbContext context) : base(context)
        {
        }
    }
}
