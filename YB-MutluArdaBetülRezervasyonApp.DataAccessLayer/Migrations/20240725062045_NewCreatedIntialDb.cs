using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class NewCreatedIntialDb : Migration
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
                    RoomNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    GuestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestBookings", x => new { x.GuestId, x.BookingId });
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
                    { new Guid("92d14418-2deb-4813-bf2d-4b3ab0b5951e"), "Harbiye, Cumhuriyet Cd. No:50, 34367 Şişli/İstanbul", new DateTime(2024, 7, 25, 9, 20, 45, 66, DateTimeKind.Local).AddTicks(8602), new DateTime(2024, 7, 25, 9, 20, 45, 66, DateTimeKind.Local).AddTicks(8603), null, "Hilton@gmail.com", true, null, "Hilton İstanbul Bosphorus", "02123156000", 5, null },
                    { new Guid("9c4eaa5f-d2b7-4ed3-9c3a-4d1a81c14d48"), "Küçük Ayasofya, Çayıroğlu Sk. No:18, 34122 Fatih/İstanbul", new DateTime(2024, 7, 25, 9, 20, 45, 66, DateTimeKind.Local).AddTicks(8577), new DateTime(2024, 7, 25, 9, 20, 45, 66, DateTimeKind.Local).AddTicks(8592), null, "CheersLighthouse@gmail.com", true, null, "Cheers Lighthouse", "02124582324", 4, null },
                    { new Guid("aaa8869d-f923-4abf-bbb4-44d4fce509a8"), "Levazım, Vadi Caddesi Zorlu Center, 34340 Beşiktaş/İstanbul", new DateTime(2024, 7, 25, 9, 20, 45, 66, DateTimeKind.Local).AddTicks(8600), new DateTime(2024, 7, 25, 9, 20, 45, 66, DateTimeKind.Local).AddTicks(8600), null, "Raffles@gmail.com", true, null, "Hotel Raffles Istanbul", "02129240200", 5, null }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("5f3b1e9a-4ace-4ba7-b10f-2fb5911db8ac"), 2, null, "Geniş ve ferah", true, null, "Çift kişilik", 2500m, null },
                    { new Guid("accdac0c-7382-41f5-a4ca-92e41435acf4"), 4, null, "Geniş oda tasarımı", true, null, "Dört kişilik", 4200m, null },
                    { new Guid("b4515eb4-bcfc-46f4-ad8c-2a90f05843ab"), 3, null, "Geniş ve şık oda", true, null, "Üç kişilik", 3500m, null },
                    { new Guid("e0a585f2-79a4-4db8-95af-348e549f53eb"), 1, null, "Şık ve ferah", true, null, "Tek kişilik", 1500m, null }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreateAt", "HotelId", "IsActive", "IsDeleted", "RoomNo", "RoomTypeId", "Status", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0c4de357-d7ba-40a0-9f75-24fd7afc3058"), null, new Guid("92d14418-2deb-4813-bf2d-4b3ab0b5951e"), true, null, "Double Oda", new Guid("5f3b1e9a-4ace-4ba7-b10f-2fb5911db8ac"), "Boş", null },
                    { new Guid("24618811-b859-4103-a858-e1cdbf8e41c4"), null, new Guid("92d14418-2deb-4813-bf2d-4b3ab0b5951e"), true, null, "King Oda", new Guid("accdac0c-7382-41f5-a4ca-92e41435acf4"), "Boş", null },
                    { new Guid("48145034-afb7-4395-bcfc-3ec41bb9acaf"), null, new Guid("92d14418-2deb-4813-bf2d-4b3ab0b5951e"), true, null, "Queen Oda", new Guid("b4515eb4-bcfc-46f4-ad8c-2a90f05843ab"), "Boş", null },
                    { new Guid("4ae5bee7-4e61-48b1-8079-66d4f2f8c948"), null, new Guid("9c4eaa5f-d2b7-4ed3-9c3a-4d1a81c14d48"), true, null, "Single Oda", new Guid("e0a585f2-79a4-4db8-95af-348e549f53eb"), "Boş", null },
                    { new Guid("5703c195-4a5a-496f-aa5d-913af0d042ea"), null, new Guid("aaa8869d-f923-4abf-bbb4-44d4fce509a8"), true, null, "Queen Oda", new Guid("b4515eb4-bcfc-46f4-ad8c-2a90f05843ab"), "Boş", null },
                    { new Guid("6a61756a-1b2f-4dfc-ac73-e16051aa566c"), null, new Guid("aaa8869d-f923-4abf-bbb4-44d4fce509a8"), true, null, "Single Oda", new Guid("e0a585f2-79a4-4db8-95af-348e549f53eb"), "Boş", null },
                    { new Guid("8cd0098e-ccd3-4ec7-86f5-711c7c3e1787"), null, new Guid("92d14418-2deb-4813-bf2d-4b3ab0b5951e"), true, null, "Single Oda", new Guid("e0a585f2-79a4-4db8-95af-348e549f53eb"), "Boş", null },
                    { new Guid("90b18030-ee56-48aa-aac3-1892e85c552b"), null, new Guid("aaa8869d-f923-4abf-bbb4-44d4fce509a8"), true, null, "Double Oda", new Guid("5f3b1e9a-4ace-4ba7-b10f-2fb5911db8ac"), "Boş", null },
                    { new Guid("916b12c9-7819-4fc0-b61b-a6f6388890c6"), null, new Guid("9c4eaa5f-d2b7-4ed3-9c3a-4d1a81c14d48"), true, null, "Queen Oda", new Guid("b4515eb4-bcfc-46f4-ad8c-2a90f05843ab"), "Boş", null },
                    { new Guid("a2b60f7e-2b27-47b8-ade2-d5659453b563"), null, new Guid("9c4eaa5f-d2b7-4ed3-9c3a-4d1a81c14d48"), true, null, "King Oda", new Guid("accdac0c-7382-41f5-a4ca-92e41435acf4"), "Boş", null },
                    { new Guid("cdc72f83-9375-4f01-90ef-60e2e80adde5"), null, new Guid("9c4eaa5f-d2b7-4ed3-9c3a-4d1a81c14d48"), true, null, "Double Oda", new Guid("5f3b1e9a-4ace-4ba7-b10f-2fb5911db8ac"), "Boş", null },
                    { new Guid("fcce1af5-8123-4f01-a075-af5331a6ef3a"), null, new Guid("aaa8869d-f923-4abf-bbb4-44d4fce509a8"), true, null, "King Oda", new Guid("accdac0c-7382-41f5-a4ca-92e41435acf4"), "Boş", null }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreateAt", "DateOfBirth", "Email", "FirstName", "HireDate", "HotelId", "IsActive", "IsDeleted", "LastName", "Phone", "Position", "Salary", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("4bea088f-b8d6-41b8-a7b6-4fd78b63fb81"), null, new DateTime(1963, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael@gmail.com", "Michael", new DateTime(1993, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aaa8869d-f923-4abf-bbb4-44d4fce509a8"), true, null, "Suyama", "(536) 555-7773", "Mutfak Şefi", 90.000m, null },
                    { new Guid("4eee4875-4361-4954-b906-02d55eee4b40"), null, new DateTime(1955, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven@gmail.com", "Steven", new DateTime(1990, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9c4eaa5f-d2b7-4ed3-9c3a-4d1a81c14d48"), true, null, "Buchanan", "(71) 555-7773", "Muhasebe Müdürü", 80.000m, null },
                    { new Guid("736e9c48-d42e-4583-b92e-96f5b216917d"), null, new DateTime(1963, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "marie@gmail.com", "Marie", new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9c4eaa5f-d2b7-4ed3-9c3a-4d1a81c14d48"), true, null, "Bertrand", "(505) 555 55 50", "Teknik Müdür", 40.000m, null },
                    { new Guid("f6e25595-84f3-402c-8211-9db116f57b23"), null, new DateTime(1960, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert@gmail.com", "Robert", new DateTime(1994, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("92d14418-2deb-4813-bf2d-4b3ab0b5951e"), true, null, "King", "(71) 555-5598", "Housekeeper", 75.000m, null }
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
