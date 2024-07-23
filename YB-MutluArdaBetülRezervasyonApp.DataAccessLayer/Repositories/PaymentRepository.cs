using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories
{
    public class PaymentRepository : GenericRepository<Payment>
    {
        public PaymentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
