using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_MutluArdaBetülRezervasyonApp.Entities.Abstractions;

namespace YB_MutluArdaBetülRezervasyonApp.Entities.Models
{
    public class Booking : BaseEntity
    {
        public string? RoomNumber { get; set; }
        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }
        public decimal? TotalPrice { get; set; }
        public Guid GuestId { get; set; }
    }
}
