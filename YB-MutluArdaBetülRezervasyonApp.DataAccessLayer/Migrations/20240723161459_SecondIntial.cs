using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class SecondIntial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("2fb24fc0-655e-4883-b905-762d010ca163"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("3ad8a0fd-fd3c-4a8c-8497-eaff0627e5fa"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("886101f9-2388-4158-b378-a7edab3d9d3c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a215e21c-2d2f-464d-aa96-5d6534dd8be1"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("1f6703db-544a-497f-ac7f-db5ec6d10f88"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("7f26f510-2a70-4efd-a18c-f86c57579e57"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("a42ccd0e-afbb-43e6-8fa2-c6aedb69ece9"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("fcdc9816-f953-486c-b721-3cd2467ff4fb"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("7cd503b4-00f9-4a23-bef3-d8397630458b"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("7fdada21-43fc-48cd-a83d-ac8e7ce69ec2"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("a089bcd3-8b76-4b54-843a-bef3f4ee8491"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("2a97293d-5a13-4839-ab7c-f366ad621550"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("71c5c113-7890-4041-a718-223459f33751"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("9b3e2872-c57c-49ea-991d-17bf9fdc0e38"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("bc8fb53e-30c2-4311-abad-ce802359fef9"));

            migrationBuilder.AlterColumn<string>(
                name: "TCNo",
                table: "Guests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "TCNo",
                table: "Guests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckinTime", "CheckoutTime", "CreateAt", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("7cd503b4-00f9-4a23-bef3-d8397630458b"), "Harbiye, Cumhuriyet Cd. No:50, 34367 Şişli/İstanbul", new DateTime(2024, 7, 23, 11, 18, 48, 375, DateTimeKind.Local).AddTicks(6670), new DateTime(2024, 7, 23, 11, 18, 48, 375, DateTimeKind.Local).AddTicks(6670), null, "Hilton@gmail.com", true, null, "Hilton İstanbul Bosphorus", "02123156000", 5, null },
                    { new Guid("7fdada21-43fc-48cd-a83d-ac8e7ce69ec2"), "Levazım, Vadi Caddesi Zorlu Center, 34340 Beşiktaş/İstanbul", new DateTime(2024, 7, 23, 11, 18, 48, 375, DateTimeKind.Local).AddTicks(6667), new DateTime(2024, 7, 23, 11, 18, 48, 375, DateTimeKind.Local).AddTicks(6668), null, "Raffles@gmail.com", true, null, "Hotel Raffles Istanbul", "02129240200", 5, null },
                    { new Guid("a089bcd3-8b76-4b54-843a-bef3f4ee8491"), "Küçük Ayasofya, Çayıroğlu Sk. No:18, 34122 Fatih/İstanbul", new DateTime(2024, 7, 23, 11, 18, 48, 375, DateTimeKind.Local).AddTicks(6652), new DateTime(2024, 7, 23, 11, 18, 48, 375, DateTimeKind.Local).AddTicks(6664), null, "CheersLighthouse@gmail.com", true, null, "Cheers Lighthouse", "02124582324", 4, null }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("2a97293d-5a13-4839-ab7c-f366ad621550"), 3, null, "3 kişinin kalabileceği genişlikte bir oda", true, null, "Üç kişilik", 3500m, null },
                    { new Guid("71c5c113-7890-4041-a718-223459f33751"), 4, null, "Geniş oda tasarımı", true, null, "Dört kişilik", 4200m, null },
                    { new Guid("9b3e2872-c57c-49ea-991d-17bf9fdc0e38"), 2, null, "Geniş ve ferah", true, null, "Çift kişilik", 2500m, null },
                    { new Guid("bc8fb53e-30c2-4311-abad-ce802359fef9"), 1, null, "Şık ve ferah", true, null, "Tek kişilik", 1500m, null }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreateAt", "HotelId", "IsActive", "IsDeleted", "RoomTypeId", "Status", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("2fb24fc0-655e-4883-b905-762d010ca163"), null, new Guid("7fdada21-43fc-48cd-a83d-ac8e7ce69ec2"), true, null, new Guid("9b3e2872-c57c-49ea-991d-17bf9fdc0e38"), "Boş", null },
                    { new Guid("3ad8a0fd-fd3c-4a8c-8497-eaff0627e5fa"), null, new Guid("7cd503b4-00f9-4a23-bef3-d8397630458b"), true, null, new Guid("2a97293d-5a13-4839-ab7c-f366ad621550"), "Boş", null },
                    { new Guid("886101f9-2388-4158-b378-a7edab3d9d3c"), null, new Guid("7fdada21-43fc-48cd-a83d-ac8e7ce69ec2"), true, null, new Guid("71c5c113-7890-4041-a718-223459f33751"), "Boş", null },
                    { new Guid("a215e21c-2d2f-464d-aa96-5d6534dd8be1"), null, new Guid("a089bcd3-8b76-4b54-843a-bef3f4ee8491"), true, null, new Guid("bc8fb53e-30c2-4311-abad-ce802359fef9"), "Boş", null }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreateAt", "DateOfBirth", "Email", "FirstName", "HireDate", "HotelId", "IsActive", "IsDeleted", "LastName", "Phone", "Position", "Salary", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("1f6703db-544a-497f-ac7f-db5ec6d10f88"), null, new DateTime(1963, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "marie@gmail.com", "Marie", new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a089bcd3-8b76-4b54-843a-bef3f4ee8491"), true, null, "Bertrand", "(505) 555 55 50", "Teknik Müdür", 40.000m, null },
                    { new Guid("7f26f510-2a70-4efd-a18c-f86c57579e57"), null, new DateTime(1955, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven@gmail.com", "Steven", new DateTime(1990, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a089bcd3-8b76-4b54-843a-bef3f4ee8491"), true, null, "Buchanan", "(71) 555-7773", "Muhasebe Müdürü", 80.000m, null },
                    { new Guid("a42ccd0e-afbb-43e6-8fa2-c6aedb69ece9"), null, new DateTime(1963, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael@gmail.com", "Michael", new DateTime(1993, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7fdada21-43fc-48cd-a83d-ac8e7ce69ec2"), true, null, "Suyama", "(536) 555-7773", "Mutfak Şefi", 90.000m, null },
                    { new Guid("fcdc9816-f953-486c-b721-3cd2467ff4fb"), null, new DateTime(1960, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert@gmail.com", "Robert", new DateTime(1994, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7cd503b4-00f9-4a23-bef3-d8397630458b"), true, null, "King", "(71) 555-5598", "Housekeeper", 75.000m, null }
                });
        }
    }
}
