using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories
{
    public class StaffRepository : GenericRepository<Staff>
    {
        public StaffRepository(AppDbContext context) : base(context)
        {
        }
    }
}
