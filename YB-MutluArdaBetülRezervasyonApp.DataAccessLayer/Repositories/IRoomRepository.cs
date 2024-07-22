using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories
{
    public class IRoomRepository : IGenericRepository<Room>
    {
        public IRoomRepository(AppDbContext context) : base(context)
        {
        }
    }
}
