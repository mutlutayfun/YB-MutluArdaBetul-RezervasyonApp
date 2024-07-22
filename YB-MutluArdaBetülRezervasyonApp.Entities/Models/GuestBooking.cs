using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_MutluArdaBetülRezervasyonApp.Entities.Abstractions;

namespace YB_MutluArdaBetülRezervasyonApp.Entities.Models
{
    public class GuestBooking : BaseEntity
    {
        public Guid GuestId { get; set; }
        public Guid BookingId { get; set; }
        public Booking? Booking { get; set; }
        public Guest? Guest { get; set; }

    }
}
