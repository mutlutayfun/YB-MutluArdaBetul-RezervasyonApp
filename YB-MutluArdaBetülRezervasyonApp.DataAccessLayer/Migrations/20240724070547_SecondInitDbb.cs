using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class SecondInitDbb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("198c267f-c8f6-46f9-8731-75c128f74af6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("2b55dd67-baa7-4b12-acbf-0428ceab121c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6edf3eef-b9ca-4eed-93c5-9447fbb59ada"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("d12238dc-2fb1-4b13-a08f-255c45bfabd5"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("15c82689-4d0d-4eda-af3d-1cc76187e1d0"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("4adf38a1-0cde-4717-ae4c-991e955f3251"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("58b7bc63-b6a7-49a8-89e6-5cc7b3c72266"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("5eaf3f5a-4d7e-44ac-ae8d-844f1893457c"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("b7fda42c-3677-4ffd-ac9d-0e29a6e979fc"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("e840b4a6-c96b-4acc-a1fb-49ef456ad74b"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("f625ebcf-c662-4f47-90ab-ac1c3e20e26d"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("1e7c1fb4-500a-4bc0-9bc6-c683d3036100"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("70a80ebe-a8b3-4639-88ff-ffd04c03ef0b"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("778f006b-acca-43dc-ab9d-88b1e437187d"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("f9ca7648-5212-41ec-bfa9-7045ef223f53"));

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckinTime", "CheckoutTime", "CreateAt", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0b0d56f3-1d53-4a1d-bf66-1161fe0b2d43"), "Küçük Ayasofya, Çayıroğlu Sk. No:18, 34122 Fatih/İstanbul", new DateTime(2024, 7, 24, 10, 5, 47, 481, DateTimeKind.Local).AddTicks(1879), new DateTime(2024, 7, 24, 10, 5, 47, 481, DateTimeKind.Local).AddTicks(1887), null, "CheersLighthouse@gmail.com", true, null, "Cheers Lighthouse", "02124582324", 4, null },
                    { new Guid("7b086720-880f-4c4f-b3d9-7d5a333b6356"), "Harbiye, Cumhuriyet Cd. No:50, 34367 Şişli/İstanbul", new DateTime(2024, 7, 24, 10, 5, 47, 481, DateTimeKind.Local).AddTicks(1893), new DateTime(2024, 7, 24, 10, 5, 47, 481, DateTimeKind.Local).AddTicks(1893), null, "Hilton@gmail.com", true, null, "Hilton İstanbul Bosphorus", "02123156000", 5, null },
                    { new Guid("de15bb69-4390-46ee-b2ba-c2c6a243253d"), "Levazım, Vadi Caddesi Zorlu Center, 34340 Beşiktaş/İstanbul", new DateTime(2024, 7, 24, 10, 5, 47, 481, DateTimeKind.Local).AddTicks(1891), new DateTime(2024, 7, 24, 10, 5, 47, 481, DateTimeKind.Local).AddTicks(1891), null, "Raffles@gmail.com", true, null, "Hotel Raffles Istanbul", "02129240200", 5, null }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("061566e6-edce-4150-b830-27ce4e1657ab"), 3, null, "3 kişinin kalabileceği genişlikte bir oda", true, null, "Üç kişilik", 3500m, null },
                    { new Guid("9dc8bdce-69a2-421f-9d69-c95e34aed80f"), 4, null, "Geniş oda tasarımı", true, null, "Dört kişilik", 4200m, null },
                    { new Guid("adc53ead-0879-44ad-83a9-691b60892c22"), 1, null, "Şık ve ferah", true, null, "Tek kişilik", 1500m, null },
                    { new Guid("ee792b48-8c04-4b32-a8b3-dc24d9c6e002"), 2, null, "Geniş ve ferah", true, null, "Çift kişilik", 2500m, null }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreateAt", "HotelId", "IsActive", "IsDeleted", "RoomNo", "RoomTypeId", "Status", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("261f7614-5c02-4f0e-badc-0adc71df459a"), null, new Guid("0b0d56f3-1d53-4a1d-bf66-1161fe0b2d43"), true, null, "Oda-1", new Guid("adc53ead-0879-44ad-83a9-691b60892c22"), "Boş", null },
                    { new Guid("b2c12bab-6648-47dd-b641-53b2a4ead40e"), null, new Guid("7b086720-880f-4c4f-b3d9-7d5a333b6356"), true, null, "Oda-3", new Guid("061566e6-edce-4150-b830-27ce4e1657ab"), "Dolu", null },
                    { new Guid("b94e0d0e-d47e-4eb4-822b-dba4b5d36b4d"), null, new Guid("de15bb69-4390-46ee-b2ba-c2c6a243253d"), true, null, "Oda-4", new Guid("9dc8bdce-69a2-421f-9d69-c95e34aed80f"), "Boş", null },
                    { new Guid("f9e4a220-28e8-45f0-8566-9c6b258514b6"), null, new Guid("de15bb69-4390-46ee-b2ba-c2c6a243253d"), true, null, "Oda-2", new Guid("ee792b48-8c04-4b32-a8b3-dc24d9c6e002"), "Dolu", null }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreateAt", "DateOfBirth", "Email", "FirstName", "HireDate", "HotelId", "IsActive", "IsDeleted", "LastName", "Phone", "Position", "Salary", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("46e990ca-c6f3-4b42-8932-45d8dcc29e34"), null, new DateTime(1963, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "marie@gmail.com", "Marie", new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0b0d56f3-1d53-4a1d-bf66-1161fe0b2d43"), true, null, "Bertrand", "(505) 555 55 50", "Teknik Müdür", 40.000m, null },
                    { new Guid("73016e22-96e0-40e7-b087-8c790871a0c1"), null, new DateTime(1960, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert@gmail.com", "Robert", new DateTime(1994, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7b086720-880f-4c4f-b3d9-7d5a333b6356"), true, null, "King", "(71) 555-5598", "Housekeeper", 75.000m, null },
                    { new Guid("8242dc60-529a-4690-85bf-af48bbb5a51f"), null, new DateTime(1963, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael@gmail.com", "Michael", new DateTime(1993, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("de15bb69-4390-46ee-b2ba-c2c6a243253d"), true, null, "Suyama", "(536) 555-7773", "Mutfak Şefi", 90.000m, null },
                    { new Guid("a659c802-27fa-45d7-9cee-adbbe9328ba6"), null, new DateTime(1955, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven@gmail.com", "Steven", new DateTime(1990, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0b0d56f3-1d53-4a1d-bf66-1161fe0b2d43"), true, null, "Buchanan", "(71) 555-7773", "Muhasebe Müdürü", 80.000m, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("261f7614-5c02-4f0e-badc-0adc71df459a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b2c12bab-6648-47dd-b641-53b2a4ead40e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b94e0d0e-d47e-4eb4-822b-dba4b5d36b4d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f9e4a220-28e8-45f0-8566-9c6b258514b6"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("46e990ca-c6f3-4b42-8932-45d8dcc29e34"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("73016e22-96e0-40e7-b087-8c790871a0c1"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("8242dc60-529a-4690-85bf-af48bbb5a51f"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("a659c802-27fa-45d7-9cee-adbbe9328ba6"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("0b0d56f3-1d53-4a1d-bf66-1161fe0b2d43"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("7b086720-880f-4c4f-b3d9-7d5a333b6356"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("de15bb69-4390-46ee-b2ba-c2c6a243253d"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("061566e6-edce-4150-b830-27ce4e1657ab"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("9dc8bdce-69a2-421f-9d69-c95e34aed80f"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("adc53ead-0879-44ad-83a9-691b60892c22"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("ee792b48-8c04-4b32-a8b3-dc24d9c6e002"));

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckinTime", "CheckoutTime", "CreateAt", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("b7fda42c-3677-4ffd-ac9d-0e29a6e979fc"), "Harbiye, Cumhuriyet Cd. No:50, 34367 Şişli/İstanbul", new DateTime(2024, 7, 24, 10, 3, 38, 925, DateTimeKind.Local).AddTicks(3482), new DateTime(2024, 7, 24, 10, 3, 38, 925, DateTimeKind.Local).AddTicks(3482), null, "Hilton@gmail.com", true, null, "Hilton İstanbul Bosphorus", "02123156000", 5, null },
                    { new Guid("e840b4a6-c96b-4acc-a1fb-49ef456ad74b"), "Levazım, Vadi Caddesi Zorlu Center, 34340 Beşiktaş/İstanbul", new DateTime(2024, 7, 24, 10, 3, 38, 925, DateTimeKind.Local).AddTicks(3479), new DateTime(2024, 7, 24, 10, 3, 38, 925, DateTimeKind.Local).AddTicks(3480), null, "Raffles@gmail.com", true, null, "Hotel Raffles Istanbul", "02129240200", 5, null },
                    { new Guid("f625ebcf-c662-4f47-90ab-ac1c3e20e26d"), "Küçük Ayasofya, Çayıroğlu Sk. No:18, 34122 Fatih/İstanbul", new DateTime(2024, 7, 24, 10, 3, 38, 925, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 7, 24, 10, 3, 38, 925, DateTimeKind.Local).AddTicks(3476), null, "CheersLighthouse@gmail.com", true, null, "Cheers Lighthouse", "02124582324", 4, null }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("1e7c1fb4-500a-4bc0-9bc6-c683d3036100"), 4, null, "Geniş oda tasarımı", true, null, "Dört kişilik", 4200m, null },
                    { new Guid("70a80ebe-a8b3-4639-88ff-ffd04c03ef0b"), 3, null, "3 kişinin kalabileceği genişlikte bir oda", true, null, "Üç kişilik", 3500m, null },
                    { new Guid("778f006b-acca-43dc-ab9d-88b1e437187d"), 2, null, "Geniş ve ferah", true, null, "Çift kişilik", 2500m, null },
                    { new Guid("f9ca7648-5212-41ec-bfa9-7045ef223f53"), 1, null, "Şık ve ferah", true, null, "Tek kişilik", 1500m, null }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreateAt", "HotelId", "IsActive", "IsDeleted", "RoomNo", "RoomTypeId", "Status", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("198c267f-c8f6-46f9-8731-75c128f74af6"), null, new Guid("f625ebcf-c662-4f47-90ab-ac1c3e20e26d"), true, null, null, new Guid("f9ca7648-5212-41ec-bfa9-7045ef223f53"), "Boş", null },
                    { new Guid("2b55dd67-baa7-4b12-acbf-0428ceab121c"), null, new Guid("e840b4a6-c96b-4acc-a1fb-49ef456ad74b"), true, null, null, new Guid("1e7c1fb4-500a-4bc0-9bc6-c683d3036100"), "Boş", null },
                    { new Guid("6edf3eef-b9ca-4eed-93c5-9447fbb59ada"), null, new Guid("b7fda42c-3677-4ffd-ac9d-0e29a6e979fc"), true, null, null, new Guid("70a80ebe-a8b3-4639-88ff-ffd04c03ef0b"), "Dolu", null },
                    { new Guid("d12238dc-2fb1-4b13-a08f-255c45bfabd5"), null, new Guid("e840b4a6-c96b-4acc-a1fb-49ef456ad74b"), true, null, null, new Guid("778f006b-acca-43dc-ab9d-88b1e437187d"), "Boş", null }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreateAt", "DateOfBirth", "Email", "FirstName", "HireDate", "HotelId", "IsActive", "IsDeleted", "LastName", "Phone", "Position", "Salary", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("15c82689-4d0d-4eda-af3d-1cc76187e1d0"), null, new DateTime(1963, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "marie@gmail.com", "Marie", new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f625ebcf-c662-4f47-90ab-ac1c3e20e26d"), true, null, "Bertrand", "(505) 555 55 50", "Teknik Müdür", 40.000m, null },
                    { new Guid("4adf38a1-0cde-4717-ae4c-991e955f3251"), null, new DateTime(1963, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael@gmail.com", "Michael", new DateTime(1993, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e840b4a6-c96b-4acc-a1fb-49ef456ad74b"), true, null, "Suyama", "(536) 555-7773", "Mutfak Şefi", 90.000m, null },
                    { new Guid("58b7bc63-b6a7-49a8-89e6-5cc7b3c72266"), null, new DateTime(1955, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven@gmail.com", "Steven", new DateTime(1990, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f625ebcf-c662-4f47-90ab-ac1c3e20e26d"), true, null, "Buchanan", "(71) 555-7773", "Muhasebe Müdürü", 80.000m, null },
                    { new Guid("5eaf3f5a-4d7e-44ac-ae8d-844f1893457c"), null, new DateTime(1960, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert@gmail.com", "Robert", new DateTime(1994, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b7fda42c-3677-4ffd-ac9d-0e29a6e979fc"), true, null, "King", "(71) 555-5598", "Housekeeper", 75.000m, null }
                });
        }
    }
}
