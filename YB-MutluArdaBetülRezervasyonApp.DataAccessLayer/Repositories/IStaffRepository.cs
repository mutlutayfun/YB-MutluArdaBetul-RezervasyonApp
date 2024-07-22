using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories
{
    public class IStaffRepository : IGenericRepository<Staff>
    {
        public IStaffRepository(AppDbContext context) : base(context)
        {
        }
    }
}
