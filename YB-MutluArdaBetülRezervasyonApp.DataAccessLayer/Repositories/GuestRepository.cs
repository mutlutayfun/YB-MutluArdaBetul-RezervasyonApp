using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories
{
    public class GuestRepository : GenericRepository<Guest>
    {
        public GuestRepository(AppDbContext context) : base(context)
        {
        }
    }
}
