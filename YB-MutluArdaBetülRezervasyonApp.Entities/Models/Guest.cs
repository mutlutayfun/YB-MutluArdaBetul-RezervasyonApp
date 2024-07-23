using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_MutluArdaBetülRezervasyonApp.Entities.Abstractions;

namespace YB_MutluArdaBetülRezervasyonApp.Entities.Models
{
    public class Guest : BaseEntity
    {
        public string? TCNo { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

        public ICollection<GuestBooking>? GuestBookings { get; set; }

        public override string ToString()
        {
            return $"{FirstName}  /  {LastName}  /  {TCNo}  /   {DateOfBirth}  /  {Email}  /  {Phone}  /  {Address}  /  {CreateAt}";
        }
    }
}
