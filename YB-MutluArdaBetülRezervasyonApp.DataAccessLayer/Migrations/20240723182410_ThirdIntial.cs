using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class ThirdIntial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0c83a21a-a5c3-4a5e-9783-7cc49594aeaf"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("194098df-882d-465b-b8a4-878abd65859b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("96958034-016d-4979-bfda-f863702a192f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b1effe20-35fe-44e8-80bb-1200c6022b31"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("55326e2c-d580-403e-b08d-10c9597913cd"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("8fb15a6a-b4c7-4d52-8b19-c90af4381013"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("92694c6b-a1ef-4960-920a-fd089fbe8a6c"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("a5176cc9-4bbb-4b28-88b3-0d00f4cf65a5"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("20e33092-3ca1-478f-b2a4-49aec63f8fcb"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("4c82ef38-305b-4b69-9c03-d3afad33aa50"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("c94705d7-bda9-4f72-b9b9-cbff87b36948"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("03eb66b3-1cab-45b6-b9d7-d0e9a0aac9d9"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("64bf8566-e88f-49a6-ae06-799d4df0bb8d"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("79ce7300-9310-4530-b40f-56f47032bd0f"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("95ee5c2c-8b84-492b-ae6a-be1a77c0f7fb"));

            migrationBuilder.DropColumn(
                name: "RoomTypeId",
                table: "Bookings");

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckinTime", "CheckoutTime", "CreateAt", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("50849fff-4abc-4c2c-a157-853cf7828ee5"), "Harbiye, Cumhuriyet Cd. No:50, 34367 Şişli/İstanbul", new DateTime(2024, 7, 23, 21, 24, 9, 742, DateTimeKind.Local).AddTicks(2210), new DateTime(2024, 7, 23, 21, 24, 9, 742, DateTimeKind.Local).AddTicks(2211), null, "Hilton@gmail.com", true, null, "Hilton İstanbul Bosphorus", "02123156000", 5, null },
                    { new Guid("c02e151d-5270-4cb6-a668-73f0bba2ecc3"), "Levazım, Vadi Caddesi Zorlu Center, 34340 Beşiktaş/İstanbul", new DateTime(2024, 7, 23, 21, 24, 9, 742, DateTimeKind.Local).AddTicks(2206), new DateTime(2024, 7, 23, 21, 24, 9, 742, DateTimeKind.Local).AddTicks(2207), null, "Raffles@gmail.com", true, null, "Hotel Raffles Istanbul", "02129240200", 5, null },
                    { new Guid("c38a5895-cb90-4650-a93f-4eb11591c301"), "Küçük Ayasofya, Çayıroğlu Sk. No:18, 34122 Fatih/İstanbul", new DateTime(2024, 7, 23, 21, 24, 9, 742, DateTimeKind.Local).AddTicks(2184), new DateTime(2024, 7, 23, 21, 24, 9, 742, DateTimeKind.Local).AddTicks(2201), null, "CheersLighthouse@gmail.com", true, null, "Cheers Lighthouse", "02124582324", 4, null }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("4df84194-3996-466f-b64f-34eddc5a926f"), 3, null, "3 kişinin kalabileceği genişlikte bir oda", true, null, "Üç kişilik", 3500m, null },
                    { new Guid("6c1d47e8-ed6f-4462-8e10-335bf931f2c6"), 2, null, "Geniş ve ferah", true, null, "Çift kişilik", 2500m, null },
                    { new Guid("c0ca3878-5814-45d1-880b-3858085e8ea2"), 1, null, "Şık ve ferah", true, null, "Tek kişilik", 1500m, null },
                    { new Guid("ebb24ebe-8204-4266-88ed-6d4a69200561"), 4, null, "Geniş oda tasarımı", true, null, "Dört kişilik", 4200m, null }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreateAt", "HotelId", "IsActive", "IsDeleted", "RoomTypeId", "Status", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("64640c4f-9cc9-4f36-99ff-44c4f6132220"), null, new Guid("c38a5895-cb90-4650-a93f-4eb11591c301"), true, null, new Guid("c0ca3878-5814-45d1-880b-3858085e8ea2"), "Boş", null },
                    { new Guid("b0d6d50b-5ead-4236-9841-82ddb8f66c33"), null, new Guid("50849fff-4abc-4c2c-a157-853cf7828ee5"), true, null, new Guid("4df84194-3996-466f-b64f-34eddc5a926f"), "Boş", null },
                    { new Guid("d934a5fa-6b6f-453a-a9f2-4fc3f4f56a8b"), null, new Guid("c02e151d-5270-4cb6-a668-73f0bba2ecc3"), true, null, new Guid("ebb24ebe-8204-4266-88ed-6d4a69200561"), "Boş", null },
                    { new Guid("fe831796-7b6b-48dd-ab55-2c33423420ac"), null, new Guid("c02e151d-5270-4cb6-a668-73f0bba2ecc3"), true, null, new Guid("6c1d47e8-ed6f-4462-8e10-335bf931f2c6"), "Boş", null }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreateAt", "DateOfBirth", "Email", "FirstName", "HireDate", "HotelId", "IsActive", "IsDeleted", "LastName", "Phone", "Position", "Salary", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("2755b14b-31c4-4c0c-a90d-410e064c3347"), null, new DateTime(1963, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael@gmail.com", "Michael", new DateTime(1993, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c02e151d-5270-4cb6-a668-73f0bba2ecc3"), true, null, "Suyama", "(536) 555-7773", "Mutfak Şefi", 90.000m, null },
                    { new Guid("60f7a6c3-0231-4f44-9999-fc30b9be4293"), null, new DateTime(1955, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven@gmail.com", "Steven", new DateTime(1990, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c38a5895-cb90-4650-a93f-4eb11591c301"), true, null, "Buchanan", "(71) 555-7773", "Muhasebe Müdürü", 80.000m, null },
                    { new Guid("8b890467-ccb9-4be2-bc7f-04a1687f32ca"), null, new DateTime(1960, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert@gmail.com", "Robert", new DateTime(1994, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("50849fff-4abc-4c2c-a157-853cf7828ee5"), true, null, "King", "(71) 555-5598", "Housekeeper", 75.000m, null },
                    { new Guid("b164efac-081d-4293-8336-31e0b6a28ea4"), null, new DateTime(1963, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "marie@gmail.com", "Marie", new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c38a5895-cb90-4650-a93f-4eb11591c301"), true, null, "Bertrand", "(505) 555 55 50", "Teknik Müdür", 40.000m, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("64640c4f-9cc9-4f36-99ff-44c4f6132220"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b0d6d50b-5ead-4236-9841-82ddb8f66c33"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("d934a5fa-6b6f-453a-a9f2-4fc3f4f56a8b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("fe831796-7b6b-48dd-ab55-2c33423420ac"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("2755b14b-31c4-4c0c-a90d-410e064c3347"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("60f7a6c3-0231-4f44-9999-fc30b9be4293"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("8b890467-ccb9-4be2-bc7f-04a1687f32ca"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("b164efac-081d-4293-8336-31e0b6a28ea4"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("50849fff-4abc-4c2c-a157-853cf7828ee5"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("c02e151d-5270-4cb6-a668-73f0bba2ecc3"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("c38a5895-cb90-4650-a93f-4eb11591c301"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("4df84194-3996-466f-b64f-34eddc5a926f"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("6c1d47e8-ed6f-4462-8e10-335bf931f2c6"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("c0ca3878-5814-45d1-880b-3858085e8ea2"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("ebb24ebe-8204-4266-88ed-6d4a69200561"));

            migrationBuilder.AddColumn<Guid>(
                name: "RoomTypeId",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckinTime", "CheckoutTime", "CreateAt", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("20e33092-3ca1-478f-b2a4-49aec63f8fcb"), "Levazım, Vadi Caddesi Zorlu Center, 34340 Beşiktaş/İstanbul", new DateTime(2024, 7, 23, 19, 14, 58, 531, DateTimeKind.Local).AddTicks(5215), new DateTime(2024, 7, 23, 19, 14, 58, 531, DateTimeKind.Local).AddTicks(5216), null, "Raffles@gmail.com", true, null, "Hotel Raffles Istanbul", "02129240200", 5, null },
                    { new Guid("4c82ef38-305b-4b69-9c03-d3afad33aa50"), "Harbiye, Cumhuriyet Cd. No:50, 34367 Şişli/İstanbul", new DateTime(2024, 7, 23, 19, 14, 58, 531, DateTimeKind.Local).AddTicks(5218), new DateTime(2024, 7, 23, 19, 14, 58, 531, DateTimeKind.Local).AddTicks(5218), null, "Hilton@gmail.com", true, null, "Hilton İstanbul Bosphorus", "02123156000", 5, null },
                    { new Guid("c94705d7-bda9-4f72-b9b9-cbff87b36948"), "Küçük Ayasofya, Çayıroğlu Sk. No:18, 34122 Fatih/İstanbul", new DateTime(2024, 7, 23, 19, 14, 58, 531, DateTimeKind.Local).AddTicks(5198), new DateTime(2024, 7, 23, 19, 14, 58, 531, DateTimeKind.Local).AddTicks(5212), null, "CheersLighthouse@gmail.com", true, null, "Cheers Lighthouse", "02124582324", 4, null }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("03eb66b3-1cab-45b6-b9d7-d0e9a0aac9d9"), 1, null, "Şık ve ferah", true, null, "Tek kişilik", 1500m, null },
                    { new Guid("64bf8566-e88f-49a6-ae06-799d4df0bb8d"), 3, null, "3 kişinin kalabileceği genişlikte bir oda", true, null, "Üç kişilik", 3500m, null },
                    { new Guid("79ce7300-9310-4530-b40f-56f47032bd0f"), 2, null, "Geniş ve ferah", true, null, "Çift kişilik", 2500m, null },
                    { new Guid("95ee5c2c-8b84-492b-ae6a-be1a77c0f7fb"), 4, null, "Geniş oda tasarımı", true, null, "Dört kişilik", 4200m, null }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreateAt", "HotelId", "IsActive", "IsDeleted", "RoomTypeId", "Status", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0c83a21a-a5c3-4a5e-9783-7cc49594aeaf"), null, new Guid("20e33092-3ca1-478f-b2a4-49aec63f8fcb"), true, null, new Guid("95ee5c2c-8b84-492b-ae6a-be1a77c0f7fb"), "Boş", null },
                    { new Guid("194098df-882d-465b-b8a4-878abd65859b"), null, new Guid("20e33092-3ca1-478f-b2a4-49aec63f8fcb"), true, null, new Guid("79ce7300-9310-4530-b40f-56f47032bd0f"), "Boş", null },
                    { new Guid("96958034-016d-4979-bfda-f863702a192f"), null, new Guid("c94705d7-bda9-4f72-b9b9-cbff87b36948"), true, null, new Guid("03eb66b3-1cab-45b6-b9d7-d0e9a0aac9d9"), "Boş", null },
                    { new Guid("b1effe20-35fe-44e8-80bb-1200c6022b31"), null, new Guid("4c82ef38-305b-4b69-9c03-d3afad33aa50"), true, null, new Guid("64bf8566-e88f-49a6-ae06-799d4df0bb8d"), "Boş", null }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreateAt", "DateOfBirth", "Email", "FirstName", "HireDate", "HotelId", "IsActive", "IsDeleted", "LastName", "Phone", "Position", "Salary", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("55326e2c-d580-403e-b08d-10c9597913cd"), null, new DateTime(1963, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael@gmail.com", "Michael", new DateTime(1993, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("20e33092-3ca1-478f-b2a4-49aec63f8fcb"), true, null, "Suyama", "(536) 555-7773", "Mutfak Şefi", 90.000m, null },
                    { new Guid("8fb15a6a-b4c7-4d52-8b19-c90af4381013"), null, new DateTime(1960, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert@gmail.com", "Robert", new DateTime(1994, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4c82ef38-305b-4b69-9c03-d3afad33aa50"), true, null, "King", "(71) 555-5598", "Housekeeper", 75.000m, null },
                    { new Guid("92694c6b-a1ef-4960-920a-fd089fbe8a6c"), null, new DateTime(1955, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven@gmail.com", "Steven", new DateTime(1990, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c94705d7-bda9-4f72-b9b9-cbff87b36948"), true, null, "Buchanan", "(71) 555-7773", "Muhasebe Müdürü", 80.000m, null },
                    { new Guid("a5176cc9-4bbb-4b28-88b3-0d00f4cf65a5"), null, new DateTime(1963, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "marie@gmail.com", "Marie", new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c94705d7-bda9-4f72-b9b9-cbff87b36948"), true, null, "Bertrand", "(505) 555 55 50", "Teknik Müdür", 40.000m, null }
                });
        }
    }
}
