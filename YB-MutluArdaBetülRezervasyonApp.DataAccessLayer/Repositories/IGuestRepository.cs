using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories
{
    public class IGuestRepository : IGenericRepository<Guest>
    {
        public IGuestRepository(AppDbContext context) : base(context)
        {
        }
    }
}
