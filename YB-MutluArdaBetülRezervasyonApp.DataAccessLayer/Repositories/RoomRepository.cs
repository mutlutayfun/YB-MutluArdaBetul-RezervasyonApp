using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories
{
    public class RoomRepository : GenericRepository<Room>
    {
        public RoomRepository(AppDbContext context) : base(context)
        {
        }
    }
}
