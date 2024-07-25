using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreatedIntialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0c4de357-d7ba-40a0-9f75-24fd7afc3058"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("24618811-b859-4103-a858-e1cdbf8e41c4"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("48145034-afb7-4395-bcfc-3ec41bb9acaf"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4ae5bee7-4e61-48b1-8079-66d4f2f8c948"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("5703c195-4a5a-496f-aa5d-913af0d042ea"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6a61756a-1b2f-4dfc-ac73-e16051aa566c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8cd0098e-ccd3-4ec7-86f5-711c7c3e1787"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("90b18030-ee56-48aa-aac3-1892e85c552b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("916b12c9-7819-4fc0-b61b-a6f6388890c6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a2b60f7e-2b27-47b8-ade2-d5659453b563"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("cdc72f83-9375-4f01-90ef-60e2e80adde5"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("fcce1af5-8123-4f01-a075-af5331a6ef3a"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("4bea088f-b8d6-41b8-a7b6-4fd78b63fb81"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("4eee4875-4361-4954-b906-02d55eee4b40"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("736e9c48-d42e-4583-b92e-96f5b216917d"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("f6e25595-84f3-402c-8211-9db116f57b23"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("92d14418-2deb-4813-bf2d-4b3ab0b5951e"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("9c4eaa5f-d2b7-4ed3-9c3a-4d1a81c14d48"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("aaa8869d-f923-4abf-bbb4-44d4fce509a8"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("5f3b1e9a-4ace-4ba7-b10f-2fb5911db8ac"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("accdac0c-7382-41f5-a4ca-92e41435acf4"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("b4515eb4-bcfc-46f4-ad8c-2a90f05843ab"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("e0a585f2-79a4-4db8-95af-348e549f53eb"));

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckinTime", "CheckoutTime", "CreateAt", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("61f4daa3-498e-4bec-918b-3655e8e7f2b6"), "Harbiye, Cumhuriyet Cd. No:50, 34367 Şişli/İstanbul", new DateTime(2024, 7, 25, 10, 51, 50, 847, DateTimeKind.Local).AddTicks(4841), new DateTime(2024, 7, 25, 10, 51, 50, 847, DateTimeKind.Local).AddTicks(4842), null, "Hilton@gmail.com", true, null, "Hilton İstanbul Bosphorus", "02123156000", 5, null },
                    { new Guid("877c6771-5171-48e6-a8fd-1b66e8ce8dba"), "Küçük Ayasofya, Çayıroğlu Sk. No:18, 34122 Fatih/İstanbul", new DateTime(2024, 7, 25, 10, 51, 50, 847, DateTimeKind.Local).AddTicks(4822), new DateTime(2024, 7, 25, 10, 51, 50, 847, DateTimeKind.Local).AddTicks(4834), null, "CheersLighthouse@gmail.com", true, null, "Cheers Lighthouse", "02124582324", 4, null },
                    { new Guid("fa451e40-cf0d-4afb-89c6-407951a14f51"), "Levazım, Vadi Caddesi Zorlu Center, 34340 Beşiktaş/İstanbul", new DateTime(2024, 7, 25, 10, 51, 50, 847, DateTimeKind.Local).AddTicks(4838), new DateTime(2024, 7, 25, 10, 51, 50, 847, DateTimeKind.Local).AddTicks(4839), null, "Raffles@gmail.com", true, null, "Hotel Raffles Istanbul", "02129240200", 5, null }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("50ff97d7-1246-4c6a-90a3-4ffd04d297b2"), 3, null, "Geniş ve şık oda", true, null, "Üç kişilik", 3500m, null },
                    { new Guid("6b447879-8e49-4bf5-b2d1-e5b56f7f020c"), 1, null, "Şık ve ferah", true, null, "Tek kişilik", 1500m, null },
                    { new Guid("7786fb07-2988-4c66-a6b4-61dcdde40fc2"), 4, null, "Geniş oda tasarımı", true, null, "Dört kişilik", 4200m, null },
                    { new Guid("910b5a05-0b2b-4807-b6b7-a9b750232fbc"), 2, null, "Geniş ve ferah", true, null, "Çift kişilik", 2500m, null }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreateAt", "HotelId", "IsActive", "IsDeleted", "RoomNo", "RoomTypeId", "Status", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("26ca9962-f0d5-499b-b486-c8cbc1d9b21f"), null, new Guid("fa451e40-cf0d-4afb-89c6-407951a14f51"), true, null, "Queen Oda", new Guid("50ff97d7-1246-4c6a-90a3-4ffd04d297b2"), "Boş", null },
                    { new Guid("284b6856-4485-428c-933f-74cdca799f66"), null, new Guid("fa451e40-cf0d-4afb-89c6-407951a14f51"), true, null, "King Oda", new Guid("7786fb07-2988-4c66-a6b4-61dcdde40fc2"), "Boş", null },
                    { new Guid("39a0466e-fdb3-4e12-8712-98cecc84495c"), null, new Guid("61f4daa3-498e-4bec-918b-3655e8e7f2b6"), true, null, "Double Oda-2", new Guid("910b5a05-0b2b-4807-b6b7-a9b750232fbc"), "Boş", null },
                    { new Guid("490bb31a-011a-46df-a3cc-ecef17e9b5e8"), null, new Guid("fa451e40-cf0d-4afb-89c6-407951a14f51"), true, null, "Double Oda-2", new Guid("910b5a05-0b2b-4807-b6b7-a9b750232fbc"), "Boş", null },
                    { new Guid("49844ee2-bb8c-4cab-83b7-c7427e3a484e"), null, new Guid("fa451e40-cf0d-4afb-89c6-407951a14f51"), true, null, "Single Oda-2", new Guid("6b447879-8e49-4bf5-b2d1-e5b56f7f020c"), "Boş", null },
                    { new Guid("618d80c6-b3ef-4021-86c8-22d050cf962b"), null, new Guid("fa451e40-cf0d-4afb-89c6-407951a14f51"), true, null, "Double Oda-1", new Guid("910b5a05-0b2b-4807-b6b7-a9b750232fbc"), "Boş", null },
                    { new Guid("6dedd382-121c-4818-af1b-fbf8b36e9180"), null, new Guid("877c6771-5171-48e6-a8fd-1b66e8ce8dba"), true, null, "King Oda", new Guid("7786fb07-2988-4c66-a6b4-61dcdde40fc2"), "Boş", null },
                    { new Guid("7955aa42-a78c-4fe4-a090-1f0f64e62d9a"), null, new Guid("877c6771-5171-48e6-a8fd-1b66e8ce8dba"), true, null, "Single Oda-1", new Guid("6b447879-8e49-4bf5-b2d1-e5b56f7f020c"), "Boş", null },
                    { new Guid("ab17173e-d3ea-4dd4-ab38-8425ce1662a0"), null, new Guid("61f4daa3-498e-4bec-918b-3655e8e7f2b6"), true, null, "Queen Oda", new Guid("50ff97d7-1246-4c6a-90a3-4ffd04d297b2"), "Boş", null },
                    { new Guid("b0f961b4-ec9d-4eca-941b-73935d7c5563"), null, new Guid("877c6771-5171-48e6-a8fd-1b66e8ce8dba"), true, null, "Single Oda-2", new Guid("6b447879-8e49-4bf5-b2d1-e5b56f7f020c"), "Boş", null },
                    { new Guid("b503fe5e-9587-4df1-abe4-109b30018070"), null, new Guid("877c6771-5171-48e6-a8fd-1b66e8ce8dba"), true, null, "Double Oda-1", new Guid("910b5a05-0b2b-4807-b6b7-a9b750232fbc"), "Boş", null },
                    { new Guid("b6dc4c57-6453-426c-91b1-7c707e9b6d60"), null, new Guid("fa451e40-cf0d-4afb-89c6-407951a14f51"), true, null, "Single Oda-1", new Guid("6b447879-8e49-4bf5-b2d1-e5b56f7f020c"), "Boş", null },
                    { new Guid("c25d804f-0fe7-4827-bdbc-a2f0bf1517ff"), null, new Guid("61f4daa3-498e-4bec-918b-3655e8e7f2b6"), true, null, "Single Oda-1", new Guid("6b447879-8e49-4bf5-b2d1-e5b56f7f020c"), "Boş", null },
                    { new Guid("c4a10928-0c57-409b-9a51-03cfdab1654c"), null, new Guid("877c6771-5171-48e6-a8fd-1b66e8ce8dba"), true, null, "Double Oda-2", new Guid("910b5a05-0b2b-4807-b6b7-a9b750232fbc"), "Boş", null },
                    { new Guid("c69c46fc-36cf-498d-87ad-7712622ed01d"), null, new Guid("877c6771-5171-48e6-a8fd-1b66e8ce8dba"), true, null, "Queen Oda", new Guid("50ff97d7-1246-4c6a-90a3-4ffd04d297b2"), "Boş", null },
                    { new Guid("c6ccfdf1-d7e6-4529-85ba-9ca477b6bde8"), null, new Guid("61f4daa3-498e-4bec-918b-3655e8e7f2b6"), true, null, "Single Oda-2", new Guid("6b447879-8e49-4bf5-b2d1-e5b56f7f020c"), "Boş", null },
                    { new Guid("c950dfa3-7b45-43a7-ab3c-e395071f124a"), null, new Guid("61f4daa3-498e-4bec-918b-3655e8e7f2b6"), true, null, "Double Oda-1", new Guid("910b5a05-0b2b-4807-b6b7-a9b750232fbc"), "Boş", null },
                    { new Guid("cd4a7d57-bc32-4d38-87b9-08e619202947"), null, new Guid("61f4daa3-498e-4bec-918b-3655e8e7f2b6"), true, null, "King Oda", new Guid("7786fb07-2988-4c66-a6b4-61dcdde40fc2"), "Boş", null }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreateAt", "DateOfBirth", "Email", "FirstName", "HireDate", "HotelId", "IsActive", "IsDeleted", "LastName", "Phone", "Position", "Salary", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("04665fd8-8fd2-4682-a4c7-45dd3b433637"), null, new DateTime(1955, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven@gmail.com", "Steven", new DateTime(1990, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("877c6771-5171-48e6-a8fd-1b66e8ce8dba"), true, null, "Buchanan", "(71) 555-7773", "Muhasebe Müdürü", 80.000m, null },
                    { new Guid("25f97a6f-2636-4104-94f6-950136a7a2c1"), null, new DateTime(1963, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael@gmail.com", "Michael", new DateTime(1993, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fa451e40-cf0d-4afb-89c6-407951a14f51"), true, null, "Suyama", "(536) 555-7773", "Mutfak Şefi", 90.000m, null },
                    { new Guid("581b6ae0-6c09-465d-a1f8-b8f49a219f93"), null, new DateTime(1963, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "marie@gmail.com", "Marie", new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("877c6771-5171-48e6-a8fd-1b66e8ce8dba"), true, null, "Bertrand", "(505) 555 55 50", "Teknik Müdür", 40.000m, null },
                    { new Guid("ebed04a9-eb95-4d64-8b15-3aa5255f3898"), null, new DateTime(1960, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert@gmail.com", "Robert", new DateTime(1994, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("61f4daa3-498e-4bec-918b-3655e8e7f2b6"), true, null, "King", "(71) 555-5598", "Housekeeper", 75.000m, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("26ca9962-f0d5-499b-b486-c8cbc1d9b21f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("284b6856-4485-428c-933f-74cdca799f66"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("39a0466e-fdb3-4e12-8712-98cecc84495c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("490bb31a-011a-46df-a3cc-ecef17e9b5e8"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("49844ee2-bb8c-4cab-83b7-c7427e3a484e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("618d80c6-b3ef-4021-86c8-22d050cf962b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6dedd382-121c-4818-af1b-fbf8b36e9180"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7955aa42-a78c-4fe4-a090-1f0f64e62d9a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ab17173e-d3ea-4dd4-ab38-8425ce1662a0"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b0f961b4-ec9d-4eca-941b-73935d7c5563"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b503fe5e-9587-4df1-abe4-109b30018070"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b6dc4c57-6453-426c-91b1-7c707e9b6d60"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c25d804f-0fe7-4827-bdbc-a2f0bf1517ff"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c4a10928-0c57-409b-9a51-03cfdab1654c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c69c46fc-36cf-498d-87ad-7712622ed01d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c6ccfdf1-d7e6-4529-85ba-9ca477b6bde8"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c950dfa3-7b45-43a7-ab3c-e395071f124a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("cd4a7d57-bc32-4d38-87b9-08e619202947"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("04665fd8-8fd2-4682-a4c7-45dd3b433637"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("25f97a6f-2636-4104-94f6-950136a7a2c1"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("581b6ae0-6c09-465d-a1f8-b8f49a219f93"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("ebed04a9-eb95-4d64-8b15-3aa5255f3898"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("61f4daa3-498e-4bec-918b-3655e8e7f2b6"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("877c6771-5171-48e6-a8fd-1b66e8ce8dba"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("fa451e40-cf0d-4afb-89c6-407951a14f51"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("50ff97d7-1246-4c6a-90a3-4ffd04d297b2"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("6b447879-8e49-4bf5-b2d1-e5b56f7f020c"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("7786fb07-2988-4c66-a6b4-61dcdde40fc2"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("910b5a05-0b2b-4807-b6b7-a9b750232fbc"));

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
        }
    }
}
