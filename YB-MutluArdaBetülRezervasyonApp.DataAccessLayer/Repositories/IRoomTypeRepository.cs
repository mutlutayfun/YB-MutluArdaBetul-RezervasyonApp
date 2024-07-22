using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories
{
    public class IRoomTypeRepository : IGenericRepository<RoomType>
    {
        public IRoomTypeRepository(AppDbContext context) : base(context)
        {
        }
    }
}
