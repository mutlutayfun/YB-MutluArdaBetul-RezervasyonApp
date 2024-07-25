using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.ConfigurationModelBuilder
{
    

    public static class ModelBuilderExtensions
    {
        public static void DefinedClasses(this ModelBuilder modelBuilder)
        {
            var guids = Helper.GenerateGuids(31);
            var hotelId1 = guids[0];
            var hotelId2 = guids[1];
            var hotelId3 = guids[2];
            var staffId1 = guids[4];
            var staffId2 = guids[5];
            var staffId3 = guids[6];
            var staffId4 = guids[7];
            var roomTypeId1 = guids[8];
            var roomTypeId2 = guids[9];
            var roomTypeId3 = guids[10];
            var roomTypeId4 = guids[11];
            var roomId1 = guids[12];
            var roomId2 = guids[13];
            var roomId3 = guids[14];
            var roomId4 = guids[15];
            var roomId5 = guids[16];
            var roomId6 = guids[17];
            var roomId7 = guids[18];
            var roomId8 = guids[19];
            var roomId9 = guids[20];
            var roomId10 = guids[21];
            var roomId11 = guids[22];
            var roomId12 = guids[23];
            var roomId13 = guids[24];
            var roomId14 = guids[25];
            var roomId15 = guids[26];
            var roomId16 = guids[27];
            var roomId17 = guids[28];
            var roomId18 = guids[29];
            var roomId19 = guids[30];

            modelBuilder.Entity<Hotel>().HasData(
            new Hotel()
            {
                Id = hotelId1,
                Name = "Cheers Lighthouse",
                Address = "Küçük Ayasofya, Çayıroğlu Sk. No:18, 34122 Fatih/İstanbul",
                Phone = "02124582324",
                Email = "CheersLighthouse@gmail.com",
                Stars = 4,
                CheckinTime = DateTime.Now,
                CheckoutTime = DateTime.Now,
                IsActive = true
            },
            new Hotel()
            {
                Id = hotelId2,
                Name = "Hotel Raffles Istanbul",
                Address = "Levazım, Vadi Caddesi Zorlu Center, 34340 Beşiktaş/İstanbul",
                Phone = "02129240200",
                Email = "Raffles@gmail.com",
                Stars = 5,
                CheckinTime = DateTime.Now,
                CheckoutTime = DateTime.Now,
                IsActive = true
            },
            new Hotel()
            {
                Id = hotelId3,
                Name = "Hilton İstanbul Bosphorus",
                Address = "Harbiye, Cumhuriyet Cd. No:50, 34367 Şişli/İstanbul",
                Phone = "02123156000",
                Email = "Hilton@gmail.com",
                Stars = 5,
                CheckinTime = DateTime.Now,
                CheckoutTime = DateTime.Now,
                IsActive = true
            });

            modelBuilder.Entity<Staff>().HasData(
            new Staff()
            {
                Id = staffId1,
                HotelId = hotelId1,
                FirstName = "Marie",
                LastName = "Bertrand",
                Position = "Teknik Müdür",
                Salary = 40.000m,
                DateOfBirth = new DateTime(1963, 08, 30),
                Phone = "(505) 555 55 50",
                Email = "marie@gmail.com",
                HireDate = new DateTime(1992, 1, 1),
                IsActive = true
            },
            new Staff()
            {
                Id = staffId2,
                HotelId = hotelId1,
                FirstName = "Steven",
                LastName = "Buchanan",
                Position = "Muhasebe Müdürü",
                Salary = 80.000m,
                DateOfBirth = new DateTime(1955, 03, 04),
                Phone = "(71) 555-7773",
                Email = "Steven@gmail.com",
                HireDate = new DateTime(1990, 10, 17),
                IsActive = true
            },
            new Staff()
            {
                Id = staffId3,
                HotelId = hotelId2,
                FirstName = "Michael",
                LastName = "Suyama",
                Position = "Mutfak Şefi",
                Salary = 90.000m,
                DateOfBirth = new DateTime(1963, 07, 02),
                Phone = "(536) 555-7773",
                Email = "Michael@gmail.com",
                HireDate = new DateTime(1993, 10, 17),
                IsActive = true
            },
            new Staff()
            {
                Id = staffId4,
                HotelId = hotelId3,
                FirstName = "Robert",
                LastName = "King",
                Position = "Housekeeper",
                Salary = 75.000m,
                DateOfBirth = new DateTime(1960, 05, 29),
                Phone = "(71) 555-5598",
                Email = "Robert@gmail.com",
                HireDate = new DateTime(1994, 01, 02),
                IsActive = true
            }
            );

            modelBuilder.Entity<RoomType>().HasData(
            new RoomType()
            {
                Id = roomTypeId1,
                Name = "Tek kişilik",
                Description = "Şık ve ferah",
                PricePerNight = 1500,
                Capacity = 1,
                IsActive = true
            },
            new RoomType()
            {
                Id = roomTypeId2,
                Name = "Çift kişilik",
                Description = "Geniş ve ferah",
                PricePerNight = 2500,
                Capacity = 2,
                IsActive = true
            },
            new RoomType()
            {
                Id = roomTypeId3,
                Name = "Üç kişilik",
                Description = "Geniş ve şık oda",
                PricePerNight = 3500,
                Capacity = 3,
                IsActive = true
            },
            new RoomType()
            {
                Id = roomTypeId4,
                Name = "Dört kişilik",
                Description = "Geniş oda tasarımı",
                PricePerNight = 4200,
                Capacity = 4,
                IsActive = true
            }
            );
            
            modelBuilder.Entity<Room>().HasData(
            new Room()
            {
                Id = roomId1,
                HotelId =hotelId1,
                RoomTypeId = roomTypeId1,
                Status = "Boş",
                RoomNo ="Single Oda-1",
                IsActive = true
            },
            new Room()
            {
                Id = roomId13,
                HotelId = hotelId1,
                RoomTypeId = roomTypeId1,
                Status = "Boş",
                RoomNo = "Single Oda-2",
                IsActive = true
            },
            new Room()
            {
                Id = roomId2,
                HotelId = hotelId1,
                RoomTypeId = roomTypeId2,
                Status = "Boş",
                RoomNo = "Double Oda-1",
                IsActive = true
            },
            new Room()
            {
                Id = roomId14,
                HotelId = hotelId1,
                RoomTypeId = roomTypeId2,
                Status = "Boş",
                RoomNo = "Double Oda-2",
                IsActive = true
            },
            new Room()
            {
                Id = roomId3,
                HotelId = hotelId1,
                RoomTypeId = roomTypeId3,
                Status = "Boş",
                RoomNo = "Queen Oda",
                IsActive = true
            },
            new Room()
            {
                Id = roomId4,
                HotelId = hotelId1,
                RoomTypeId = roomTypeId4,
                Status = "Boş",
                RoomNo = "King Oda",
                IsActive = true
            },
            new Room()
            {
                Id = roomId5,
                HotelId = hotelId2,
                RoomTypeId = roomTypeId1,
                Status = "Boş",
                RoomNo = "Single Oda-1",
                IsActive = true
            },
            new Room()
            {
                Id = roomId15,
                HotelId = hotelId2,
                RoomTypeId = roomTypeId1,
                Status = "Boş",
                RoomNo = "Single Oda-2",
                IsActive = true
            },
            new Room()
            {
                Id = roomId6,
                HotelId = hotelId2,
                RoomTypeId = roomTypeId2,
                Status = "Boş",
                RoomNo = "Double Oda-1",
                IsActive = true
            },
            new Room()
            {
                Id = roomId16,
                HotelId = hotelId2,
                RoomTypeId = roomTypeId2,
                Status = "Boş",
                RoomNo = "Double Oda-2",
                IsActive = true
            },
            new Room()
            {
                Id = roomId7,
                HotelId = hotelId2,
                RoomTypeId = roomTypeId3,
                Status = "Boş",
                RoomNo = "Queen Oda",
                IsActive = true
            },
            new Room()
            {
                Id = roomId8,
                HotelId = hotelId2,
                RoomTypeId = roomTypeId4,
                Status = "Boş",
                RoomNo = "King Oda",
                IsActive = true
            },
            new Room()
            {
                Id = roomId9,
                HotelId = hotelId3,
                RoomTypeId = roomTypeId1,
                Status = "Boş",
                RoomNo = "Single Oda-1",
                IsActive = true
            },
            new Room()
            {
                Id = roomId17,
                HotelId = hotelId3,
                RoomTypeId = roomTypeId1,
                Status = "Boş",
                RoomNo = "Single Oda-2",
                IsActive = true
            },
            new Room()
            {
                Id = roomId10,
                HotelId = hotelId3,
                RoomTypeId = roomTypeId2,
                Status = "Boş",
                RoomNo = "Double Oda-1",
                IsActive = true
            },
            new Room()
            {
                Id = roomId18,
                HotelId = hotelId3,
                RoomTypeId = roomTypeId2,
                Status = "Boş",
                RoomNo = "Double Oda-2",
                IsActive = true
            },
            new Room()
            {
                Id = roomId11,
                HotelId = hotelId3,
                RoomTypeId = roomTypeId3,
                Status = "Boş",
                RoomNo = "Queen Oda",
                IsActive = true
            },
            new Room()
            {
                Id = roomId12,
                HotelId = hotelId3,
                RoomTypeId = roomTypeId4,
                Status = "Boş",
                RoomNo = "King Oda",
                IsActive = true
            });
        }
    }
}
