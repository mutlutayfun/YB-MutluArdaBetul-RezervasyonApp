using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories
{
    public class HotelRepository : GenericRepository<Hotel>
    {
        public HotelRepository(AppDbContext context) : base(context)
        {
        }
    }
}
