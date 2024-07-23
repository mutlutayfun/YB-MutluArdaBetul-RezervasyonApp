using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories
{
    public class RoomTypeRepository : GenericRepository<RoomType>
    {
        public RoomTypeRepository(AppDbContext context) : base(context)
        {
        }
    }
}
