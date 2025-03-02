﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context;

#nullable disable

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("YB_MutluArdaBetülRezervasyonApp.Entities.Models.Booking", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CheckinDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckoutDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoomTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("YB_MutluArdaBetülRezervasyonApp.Entities.Models.Guest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("YB_MutluArdaBetülRezervasyonApp.Entities.Models.GuestBooking", b =>
                {
                    b.Property<Guid>("GuestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("GuestId", "BookingId");

                    b.HasIndex("BookingId");

                    b.ToTable("GuestBookings");
                });

            modelBuilder.Entity("YB_MutluArdaBetülRezervasyonApp.Entities.Models.Hotel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CheckinTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckoutTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = new Guid("877c6771-5171-48e6-a8fd-1b66e8ce8dba"),
                            Address = "Küçük Ayasofya, Çayıroğlu Sk. No:18, 34122 Fatih/İstanbul",
                            CheckinTime = new DateTime(2024, 7, 25, 10, 51, 50, 847, DateTimeKind.Local).AddTicks(4822),
                            CheckoutTime = new DateTime(2024, 7, 25, 10, 51, 50, 847, DateTimeKind.Local).AddTicks(4834),
                            Email = "CheersLighthouse@gmail.com",
                            IsActive = true,
                            Name = "Cheers Lighthouse",
                            Phone = "02124582324",
                            Stars = 4
                        },
                        new
                        {
                            Id = new Guid("fa451e40-cf0d-4afb-89c6-407951a14f51"),
                            Address = "Levazım, Vadi Caddesi Zorlu Center, 34340 Beşiktaş/İstanbul",
                            CheckinTime = new DateTime(2024, 7, 25, 10, 51, 50, 847, DateTimeKind.Local).AddTicks(4838),
                            CheckoutTime = new DateTime(2024, 7, 25, 10, 51, 50, 847, DateTimeKind.Local).AddTicks(4839),
                            Email = "Raffles@gmail.com",
                            IsActive = true,
                            Name = "Hotel Raffles Istanbul",
                            Phone = "02129240200",
                            Stars = 5
                        },
                        new
                        {
                            Id = new Guid("61f4daa3-498e-4bec-918b-3655e8e7f2b6"),
                            Address = "Harbiye, Cumhuriyet Cd. No:50, 34367 Şişli/İstanbul",
                            CheckinTime = new DateTime(2024, 7, 25, 10, 51, 50, 847, DateTimeKind.Local).AddTicks(4841),
                            CheckoutTime = new DateTime(2024, 7, 25, 10, 51, 50, 847, DateTimeKind.Local).AddTicks(4842),
                            Email = "Hilton@gmail.com",
                            IsActive = true,
                            Name = "Hilton İstanbul Bosphorus",
                            Phone = "02123156000",
                            Stars = 5
                        });
                });

            modelBuilder.Entity("YB_MutluArdaBetülRezervasyonApp.Entities.Models.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("BookingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("YB_MutluArdaBetülRezervasyonApp.Entities.Models.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("RoomNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoomTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7955aa42-a78c-4fe4-a090-1f0f64e62d9a"),
                            HotelId = new Guid("877c6771-5171-48e6-a8fd-1b66e8ce8dba"),
                            IsActive = true,
                            RoomNo = "Single Oda-1",
                            RoomTypeId = new Guid("6b447879-8e49-4bf5-b2d1-e5b56f7f020c"),
                            Status = "Boş"
                        },
                        new
                        {
                            Id = new Guid("b0f961b4-ec9d-4eca-941b-73935d7c5563"),
                            HotelId = new Guid("877c6771-5171-48e6-a8fd-1b66e8ce8dba"),
                            IsActive = true,
                            RoomNo = "Single Oda-2",
                            RoomTypeId = new Guid("6b447879-8e49-4bf5-b2d1-e5b56f7f020c"),
                            Status = "Boş"
                        },
                        new
                        {
                            Id = new Guid("b503fe5e-9587-4df1-abe4-109b30018070"),
                            HotelId = new Guid("877c6771-5171-48e6-a8fd-1b66e8ce8dba"),
                            IsActive = true,
                            RoomNo = "Double Oda-1",
                            RoomTypeId = new Guid("910b5a05-0b2b-4807-b6b7-a9b750232fbc"),
                            Status = "Boş"
                        },
                        new
                        {
                            Id = new Guid("c4a10928-0c57-409b-9a51-03cfdab1654c"),
                            HotelId = new Guid("877c6771-5171-48e6-a8fd-1b66e8ce8dba"),
                            IsActive = true,
                            RoomNo = "Double Oda-2",
                            RoomTypeId = new Guid("910b5a05-0b2b-4807-b6b7-a9b750232fbc"),
                            Status = "Boş"
                        },
                        new
                        {
                            Id = new Guid("c69c46fc-36cf-498d-87ad-7712622ed01d"),
                            HotelId = new Guid("877c6771-5171-48e6-a8fd-1b66e8ce8dba"),
                            IsActive = true,
                            RoomNo = "Queen Oda",
                            RoomTypeId = new Guid("50ff97d7-1246-4c6a-90a3-4ffd04d297b2"),
                            Status = "Boş"
                        },
                        new
                        {
                            Id = new Guid("6dedd382-121c-4818-af1b-fbf8b36e9180"),
                            HotelId = new Guid("877c6771-5171-48e6-a8fd-1b66e8ce8dba"),
                            IsActive = true,
                            RoomNo = "King Oda",
                            RoomTypeId = new Guid("7786fb07-2988-4c66-a6b4-61dcdde40fc2"),
                            Status = "Boş"
                        },
                        new
                        {
                            Id = new Guid("b6dc4c57-6453-426c-91b1-7c707e9b6d60"),
                            HotelId = new Guid("fa451e40-cf0d-4afb-89c6-407951a14f51"),
                            IsActive = true,
                            RoomNo = "Single Oda-1",
                            RoomTypeId = new Guid("6b447879-8e49-4bf5-b2d1-e5b56f7f020c"),
                            Status = "Boş"
                        },
                        new
                        {
                            Id = new Guid("49844ee2-bb8c-4cab-83b7-c7427e3a484e"),
                            HotelId = new Guid("fa451e40-cf0d-4afb-89c6-407951a14f51"),
                            IsActive = true,
                            RoomNo = "Single Oda-2",
                            RoomTypeId = new Guid("6b447879-8e49-4bf5-b2d1-e5b56f7f020c"),
                            Status = "Boş"
                        },
                        new
                        {
                            Id = new Guid("618d80c6-b3ef-4021-86c8-22d050cf962b"),
                            HotelId = new Guid("fa451e40-cf0d-4afb-89c6-407951a14f51"),
                            IsActive = true,
                            RoomNo = "Double Oda-1",
                            RoomTypeId = new Guid("910b5a05-0b2b-4807-b6b7-a9b750232fbc"),
                            Status = "Boş"
                        },
                        new
                        {
                            Id = new Guid("490bb31a-011a-46df-a3cc-ecef17e9b5e8"),
                            HotelId = new Guid("fa451e40-cf0d-4afb-89c6-407951a14f51"),
                            IsActive = true,
                            RoomNo = "Double Oda-2",
                            RoomTypeId = new Guid("910b5a05-0b2b-4807-b6b7-a9b750232fbc"),
                            Status = "Boş"
                        },
                        new
                        {
                            Id = new Guid("26ca9962-f0d5-499b-b486-c8cbc1d9b21f"),
                            HotelId = new Guid("fa451e40-cf0d-4afb-89c6-407951a14f51"),
                            IsActive = true,
                            RoomNo = "Queen Oda",
                            RoomTypeId = new Guid("50ff97d7-1246-4c6a-90a3-4ffd04d297b2"),
                            Status = "Boş"
                        },
                        new
                        {
                            Id = new Guid("284b6856-4485-428c-933f-74cdca799f66"),
                            HotelId = new Guid("fa451e40-cf0d-4afb-89c6-407951a14f51"),
                            IsActive = true,
                            RoomNo = "King Oda",
                            RoomTypeId = new Guid("7786fb07-2988-4c66-a6b4-61dcdde40fc2"),
                            Status = "Boş"
                        },
                        new
                        {
                            Id = new Guid("c25d804f-0fe7-4827-bdbc-a2f0bf1517ff"),
                            HotelId = new Guid("61f4daa3-498e-4bec-918b-3655e8e7f2b6"),
                            IsActive = true,
                            RoomNo = "Single Oda-1",
                            RoomTypeId = new Guid("6b447879-8e49-4bf5-b2d1-e5b56f7f020c"),
                            Status = "Boş"
                        },
                        new
                        {
                            Id = new Guid("c6ccfdf1-d7e6-4529-85ba-9ca477b6bde8"),
                            HotelId = new Guid("61f4daa3-498e-4bec-918b-3655e8e7f2b6"),
                            IsActive = true,
                            RoomNo = "Single Oda-2",
                            RoomTypeId = new Guid("6b447879-8e49-4bf5-b2d1-e5b56f7f020c"),
                            Status = "Boş"
                        },
                        new
                        {
                            Id = new Guid("c950dfa3-7b45-43a7-ab3c-e395071f124a"),
                            HotelId = new Guid("61f4daa3-498e-4bec-918b-3655e8e7f2b6"),
                            IsActive = true,
                            RoomNo = "Double Oda-1",
                            RoomTypeId = new Guid("910b5a05-0b2b-4807-b6b7-a9b750232fbc"),
                            Status = "Boş"
                        },
                        new
                        {
                            Id = new Guid("39a0466e-fdb3-4e12-8712-98cecc84495c"),
                            HotelId = new Guid("61f4daa3-498e-4bec-918b-3655e8e7f2b6"),
                            IsActive = true,
                            RoomNo = "Double Oda-2",
                            RoomTypeId = new Guid("910b5a05-0b2b-4807-b6b7-a9b750232fbc"),
                            Status = "Boş"
                        },
                        new
                        {
                            Id = new Guid("ab17173e-d3ea-4dd4-ab38-8425ce1662a0"),
                            HotelId = new Guid("61f4daa3-498e-4bec-918b-3655e8e7f2b6"),
                            IsActive = true,
                            RoomNo = "Queen Oda",
                            RoomTypeId = new Guid("50ff97d7-1246-4c6a-90a3-4ffd04d297b2"),
                            Status = "Boş"
                        },
                        new
                        {
                            Id = new Guid("cd4a7d57-bc32-4d38-87b9-08e619202947"),
                            HotelId = new Guid("61f4daa3-498e-4bec-918b-3655e8e7f2b6"),
                            IsActive = true,
                            RoomNo = "King Oda",
                            RoomTypeId = new Guid("7786fb07-2988-4c66-a6b4-61dcdde40fc2"),
                            Status = "Boş"
                        });
                });

            modelBuilder.Entity("YB_MutluArdaBetülRezervasyonApp.Entities.Models.RoomType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PricePerNight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("RoomTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6b447879-8e49-4bf5-b2d1-e5b56f7f020c"),
                            Capacity = 1,
                            Description = "Şık ve ferah",
                            IsActive = true,
                            Name = "Tek kişilik",
                            PricePerNight = 1500m
                        },
                        new
                        {
                            Id = new Guid("910b5a05-0b2b-4807-b6b7-a9b750232fbc"),
                            Capacity = 2,
                            Description = "Geniş ve ferah",
                            IsActive = true,
                            Name = "Çift kişilik",
                            PricePerNight = 2500m
                        },
                        new
                        {
                            Id = new Guid("50ff97d7-1246-4c6a-90a3-4ffd04d297b2"),
                            Capacity = 3,
                            Description = "Geniş ve şık oda",
                            IsActive = true,
                            Name = "Üç kişilik",
                            PricePerNight = 3500m
                        },
                        new
                        {
                            Id = new Guid("7786fb07-2988-4c66-a6b4-61dcdde40fc2"),
                            Capacity = 4,
                            Description = "Geniş oda tasarımı",
                            IsActive = true,
                            Name = "Dört kişilik",
                            PricePerNight = 4200m
                        });
                });

            modelBuilder.Entity("YB_MutluArdaBetülRezervasyonApp.Entities.Models.Staff", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Staffs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("581b6ae0-6c09-465d-a1f8-b8f49a219f93"),
                            DateOfBirth = new DateTime(1963, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "marie@gmail.com",
                            FirstName = "Marie",
                            HireDate = new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelId = new Guid("877c6771-5171-48e6-a8fd-1b66e8ce8dba"),
                            IsActive = true,
                            LastName = "Bertrand",
                            Phone = "(505) 555 55 50",
                            Position = "Teknik Müdür",
                            Salary = 40.000m
                        },
                        new
                        {
                            Id = new Guid("04665fd8-8fd2-4682-a4c7-45dd3b433637"),
                            DateOfBirth = new DateTime(1955, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Steven@gmail.com",
                            FirstName = "Steven",
                            HireDate = new DateTime(1990, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelId = new Guid("877c6771-5171-48e6-a8fd-1b66e8ce8dba"),
                            IsActive = true,
                            LastName = "Buchanan",
                            Phone = "(71) 555-7773",
                            Position = "Muhasebe Müdürü",
                            Salary = 80.000m
                        },
                        new
                        {
                            Id = new Guid("25f97a6f-2636-4104-94f6-950136a7a2c1"),
                            DateOfBirth = new DateTime(1963, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Michael@gmail.com",
                            FirstName = "Michael",
                            HireDate = new DateTime(1993, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelId = new Guid("fa451e40-cf0d-4afb-89c6-407951a14f51"),
                            IsActive = true,
                            LastName = "Suyama",
                            Phone = "(536) 555-7773",
                            Position = "Mutfak Şefi",
                            Salary = 90.000m
                        },
                        new
                        {
                            Id = new Guid("ebed04a9-eb95-4d64-8b15-3aa5255f3898"),
                            DateOfBirth = new DateTime(1960, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Robert@gmail.com",
                            FirstName = "Robert",
                            HireDate = new DateTime(1994, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelId = new Guid("61f4daa3-498e-4bec-918b-3655e8e7f2b6"),
                            IsActive = true,
                            LastName = "King",
                            Phone = "(71) 555-5598",
                            Position = "Housekeeper",
                            Salary = 75.000m
                        });
                });

            modelBuilder.Entity("YB_MutluArdaBetülRezervasyonApp.Entities.Models.Booking", b =>
                {
                    b.HasOne("YB_MutluArdaBetülRezervasyonApp.Entities.Models.Room", "Room")
                        .WithMany("Bookings")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("YB_MutluArdaBetülRezervasyonApp.Entities.Models.GuestBooking", b =>
                {
                    b.HasOne("YB_MutluArdaBetülRezervasyonApp.Entities.Models.Booking", "Booking")
                        .WithMany("GuestBookings")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YB_MutluArdaBetülRezervasyonApp.Entities.Models.Guest", "Guest")
                        .WithMany("GuestBookings")
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Guest");
                });

            modelBuilder.Entity("YB_MutluArdaBetülRezervasyonApp.Entities.Models.Payment", b =>
                {
                    b.HasOne("YB_MutluArdaBetülRezervasyonApp.Entities.Models.Booking", "Booking")
                        .WithMany("Payments")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("YB_MutluArdaBetülRezervasyonApp.Entities.Models.Room", b =>
                {
                    b.HasOne("YB_MutluArdaBetülRezervasyonApp.Entities.Models.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YB_MutluArdaBetülRezervasyonApp.Entities.Models.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("YB_MutluArdaBetülRezervasyonApp.Entities.Models.Staff", b =>
                {
                    b.HasOne("YB_MutluArdaBetülRezervasyonApp.Entities.Models.Hotel", "Hotel")
                        .WithMany("Staffs")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("YB_MutluArdaBetülRezervasyonApp.Entities.Models.Booking", b =>
                {
                    b.Navigation("GuestBookings");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("YB_MutluArdaBetülRezervasyonApp.Entities.Models.Guest", b =>
                {
                    b.Navigation("GuestBookings");
                });

            modelBuilder.Entity("YB_MutluArdaBetülRezervasyonApp.Entities.Models.Hotel", b =>
                {
                    b.Navigation("Rooms");

                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("YB_MutluArdaBetülRezervasyonApp.Entities.Models.Room", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("YB_MutluArdaBetülRezervasyonApp.Entities.Models.RoomType", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
