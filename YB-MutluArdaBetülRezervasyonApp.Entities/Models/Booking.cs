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
        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }
        public decimal? TotalPrice { get; set; }
        public Guid GuestId { get; set; }
        public Guest? Guest { get; set; }

        public Guid RoomId { get; set; }
        public Room? Room { get; set; }
        
        ICollection<Payment>? Payments { get; set; }
    }
}
