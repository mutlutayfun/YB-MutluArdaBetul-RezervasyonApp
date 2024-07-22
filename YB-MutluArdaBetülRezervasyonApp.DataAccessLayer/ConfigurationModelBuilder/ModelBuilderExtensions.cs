using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.ConfigurationModelBuilder
{
    public class ModelBuilderExtensions
    {
        public static void DefinedClasses(ModelBuilder modelBuilder)
        {
            var hotelId1 = Guid.Parse("b2a71efc-3f76-4e28-9e16-0fc5d717fd61");
            var hotelId2 = Guid.Parse("c2a71efc-3f76-4e28-9e16-0fc5d717fd61");
            var hotelId3 = Guid.Parse("a2a71efc-3f76-4e28-9e16-0fc5d717fd61");

            modelBuilder.Entity<Hotel>().HasData(
            new Hotel()
            {
                Id = hotelId1,
                Name = "Cheers Lighthouse",
                Address = "Küçük Ayasofya, Çayıroğlu Sk. No:18, 34122 Fatih/İstanbul",
                Phone = "02124582324",
                Email = "CheersLighthouse@gmail.com",
                Stars = 4,
                CheckinTime = new DateTime(2024, 1, 1, 14, 0, 0).TimeOfDay,
                CheckoutTime = new DateTime(2024, 1, 1, 11, 0, 0).TimeOfDay
            },
            new Hotel()
            {
                Id = hotelId2,
                Name = "Hotel Raffles Istanbul",
                Address = "Levazım, Vadi Caddesi Zorlu Center, 34340 Beşiktaş/İstanbul",
                Phone = "02129240200",
                Email = "Raffles@gmail.com",
                Stars = 5,
                CheckinTime = new DateTime(2024, 1, 1, 15, 0, 0).TimeOfDay,
                CheckoutTime = new DateTime(2024, 1, 1, 12, 0, 0).TimeOfDay
            },
            new Hotel()
            {
                Id = hotelId3,
                Name = "Hilton İstanbul Bosphorus",
                Address = "Harbiye, Cumhuriyet Cd. No:50, 34367 Şişli/İstanbul",
                Phone = "02123156000",
                Email = "Hilton@gmail.com",
                Stars = 5,
                CheckinTime = new DateTime(2024, 1, 1, 14, 0, 0).TimeOfDay,
                CheckoutTime = new DateTime(2024, 1, 1, 12, 0, 0).TimeOfDay
            }
            );

            modelBuilder.Entity<Staff>().HasData(
            new Staff()
            {
                Id = Guid.Parse("f0c5a1d3-0f1c-4e9b-bba8-b569d4e3a1d0"),
                HotelId = hotelId1,
                FirstName = "Marie",
                LastName = "Bertrand",
                Position = "Teknik Müdür",
                Salary = 40.000m,
                DateOfBirth = new DateTime(1963, 08, 30),
                Phone = "(505) 555 55 50",
                Email = "marie@gmail.com",
                HireDate = new DateTime(1992, 1, 1)
            },
            new Staff()
            {
                Id = Guid.Parse("f0c6a1d3-0f1c-4e9b-bba8-b569d4e3a1d0"),
                HotelId = hotelId1,
                FirstName = "Steven",
                LastName = "Buchanan",
                Position = "Muhasebe Müdürü",
                Salary = 80.000m,
                DateOfBirth = new DateTime(1955, 03, 04),
                Phone = "(71) 555-7773",
                Email = "Steven@gmail.com",
                HireDate = new DateTime(1990, 10, 17)
            },
            new Staff()
            {
                Id = Guid.Parse("f0c3a1d3-0f1c-4e9b-bba8-b569d4e3a1d0"),
                HotelId = hotelId2,
                FirstName = "Michael",
                LastName = "Suyama",
                Position = "Mutfak Şefi",
                Salary = 90.000m,
                DateOfBirth = new DateTime(1963, 07, 02),
                Phone = "(536) 555-7773",
                Email = "Michael@gmail.com",
                HireDate = new DateTime(1993, 10, 17)
            },
            new Staff()
            {
                Id = Guid.Parse("f0c6a1d9-0f1c-4e9b-bba8-b569d4e3a1d0"),
                HotelId = hotelId3,
                FirstName = "Robert",
                LastName = "King",
                Position = "Housekeeper",
                Salary = 75.000m,
                DateOfBirth = new DateTime(1960, 05, 29),
                Phone = "(71) 555-5598",
                Email = "Robert@gmail.com",
                HireDate = new DateTime(1994, 01, 02)
            }
            );
        }
    }
}
