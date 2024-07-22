using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories
{
    public class IHotelRepository : IGenericRepository<Hotel>
    {
        public IHotelRepository(AppDbContext context) : base(context)
        {
        }
    }
}
