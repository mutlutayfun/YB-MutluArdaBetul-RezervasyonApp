using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class SecondInitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("286bcf71-4b48-4af5-a787-6ab801d48330"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("375ae55c-ba37-4c3e-a714-f8ea82f98f28"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a60f49f2-3998-47aa-b0fd-8a8f333eeb76"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b12174c4-52fe-4db7-b108-afe13b5a4cf1"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("21bb78d9-9950-4a6c-9d13-3d52f315b75d"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("56e9331e-d1c5-4579-a2e5-ee422a2a7df2"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("a6093dcf-73f6-4555-9607-0c3e86a2a201"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("ff96b915-3a96-48c7-bd60-6fbd02247138"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("9a97be0a-1bf7-4806-ad83-373c59100826"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("af3edd8e-e2cd-4909-8df3-9e9e80a9c383"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("b774ce45-5cd5-440c-b87b-d3ea22ce8883"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("3d3d9ea1-71ee-4333-908e-8b564a7bc508"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("aad8e986-474f-4118-a7a6-9dec94d8c0b3"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("d1db5e48-728a-41fd-92d2-d7b10ba122b3"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("eccf802a-3cd5-497c-958c-5f9e31d1467b"));

            migrationBuilder.AddColumn<string>(
                name: "RoomNo",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "RoomNo",
                table: "Rooms");

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckinTime", "CheckoutTime", "CreateAt", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("9a97be0a-1bf7-4806-ad83-373c59100826"), "Harbiye, Cumhuriyet Cd. No:50, 34367 Şişli/İstanbul", new DateTime(2024, 7, 24, 9, 32, 4, 959, DateTimeKind.Local).AddTicks(9550), new DateTime(2024, 7, 24, 9, 32, 4, 959, DateTimeKind.Local).AddTicks(9551), null, "Hilton@gmail.com", true, null, "Hilton İstanbul Bosphorus", "02123156000", 5, null },
                    { new Guid("af3edd8e-e2cd-4909-8df3-9e9e80a9c383"), "Levazım, Vadi Caddesi Zorlu Center, 34340 Beşiktaş/İstanbul", new DateTime(2024, 7, 24, 9, 32, 4, 959, DateTimeKind.Local).AddTicks(9548), new DateTime(2024, 7, 24, 9, 32, 4, 959, DateTimeKind.Local).AddTicks(9548), null, "Raffles@gmail.com", true, null, "Hotel Raffles Istanbul", "02129240200", 5, null },
                    { new Guid("b774ce45-5cd5-440c-b87b-d3ea22ce8883"), "Küçük Ayasofya, Çayıroğlu Sk. No:18, 34122 Fatih/İstanbul", new DateTime(2024, 7, 24, 9, 32, 4, 959, DateTimeKind.Local).AddTicks(9535), new DateTime(2024, 7, 24, 9, 32, 4, 959, DateTimeKind.Local).AddTicks(9546), null, "CheersLighthouse@gmail.com", true, null, "Cheers Lighthouse", "02124582324", 4, null }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("3d3d9ea1-71ee-4333-908e-8b564a7bc508"), 1, null, "Şık ve ferah", true, null, "Tek kişilik", 1500m, null },
                    { new Guid("aad8e986-474f-4118-a7a6-9dec94d8c0b3"), 3, null, "3 kişinin kalabileceği genişlikte bir oda", true, null, "Üç kişilik", 3500m, null },
                    { new Guid("d1db5e48-728a-41fd-92d2-d7b10ba122b3"), 4, null, "Geniş oda tasarımı", true, null, "Dört kişilik", 4200m, null },
                    { new Guid("eccf802a-3cd5-497c-958c-5f9e31d1467b"), 2, null, "Geniş ve ferah", true, null, "Çift kişilik", 2500m, null }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreateAt", "HotelId", "IsActive", "IsDeleted", "RoomTypeId", "Status", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("286bcf71-4b48-4af5-a787-6ab801d48330"), null, new Guid("af3edd8e-e2cd-4909-8df3-9e9e80a9c383"), true, null, new Guid("d1db5e48-728a-41fd-92d2-d7b10ba122b3"), "Boş", null },
                    { new Guid("375ae55c-ba37-4c3e-a714-f8ea82f98f28"), null, new Guid("b774ce45-5cd5-440c-b87b-d3ea22ce8883"), true, null, new Guid("3d3d9ea1-71ee-4333-908e-8b564a7bc508"), "Boş", null },
                    { new Guid("a60f49f2-3998-47aa-b0fd-8a8f333eeb76"), null, new Guid("9a97be0a-1bf7-4806-ad83-373c59100826"), true, null, new Guid("aad8e986-474f-4118-a7a6-9dec94d8c0b3"), "Boş", null },
                    { new Guid("b12174c4-52fe-4db7-b108-afe13b5a4cf1"), null, new Guid("af3edd8e-e2cd-4909-8df3-9e9e80a9c383"), true, null, new Guid("eccf802a-3cd5-497c-958c-5f9e31d1467b"), "Boş", null }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreateAt", "DateOfBirth", "Email", "FirstName", "HireDate", "HotelId", "IsActive", "IsDeleted", "LastName", "Phone", "Position", "Salary", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("21bb78d9-9950-4a6c-9d13-3d52f315b75d"), null, new DateTime(1960, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert@gmail.com", "Robert", new DateTime(1994, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a97be0a-1bf7-4806-ad83-373c59100826"), true, null, "King", "(71) 555-5598", "Housekeeper", 75.000m, null },
                    { new Guid("56e9331e-d1c5-4579-a2e5-ee422a2a7df2"), null, new DateTime(1963, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "marie@gmail.com", "Marie", new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b774ce45-5cd5-440c-b87b-d3ea22ce8883"), true, null, "Bertrand", "(505) 555 55 50", "Teknik Müdür", 40.000m, null },
                    { new Guid("a6093dcf-73f6-4555-9607-0c3e86a2a201"), null, new DateTime(1963, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael@gmail.com", "Michael", new DateTime(1993, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("af3edd8e-e2cd-4909-8df3-9e9e80a9c383"), true, null, "Suyama", "(536) 555-7773", "Mutfak Şefi", 90.000m, null },
                    { new Guid("ff96b915-3a96-48c7-bd60-6fbd02247138"), null, new DateTime(1955, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven@gmail.com", "Steven", new DateTime(1990, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b774ce45-5cd5-440c-b87b-d3ea22ce8883"), true, null, "Buchanan", "(71) 555-7773", "Muhasebe Müdürü", 80.000m, null }
                });
        }
    }
}
