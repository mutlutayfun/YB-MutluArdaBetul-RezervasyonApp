using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TCNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stars = table.Column<int>(type: "int", nullable: false),
                    CheckinTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckoutTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricePerNight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HotelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HotelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CheckinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckoutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuestBookings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestBookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuestBookings_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuestBookings_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RoomId",
                table: "Bookings",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_GuestBookings_BookingId",
                table: "GuestBookings",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_GuestBookings_GuestId",
                table: "GuestBookings",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_BookingId",
                table: "Payments",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelId",
                table: "Rooms",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_HotelId",
                table: "Staffs",
                column: "HotelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GuestBookings");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "RoomTypes");
        }
    }
}
