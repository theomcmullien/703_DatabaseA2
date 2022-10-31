﻿// <auto-generated />
using System;
using Assignment2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment2.Migrations
{
    [DbContext(typeof(Assignment2Context))]
    [Migration("20221031055110_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Assignment2.Areas.Identity.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("CompanyID")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TravelAgencyID")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Assignment2.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"), 1L, 1);

                    b.Property<string>("BookingCardCCV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookingCardExiryDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookingCardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookingEndDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BookingIsPaid")
                        .HasColumnType("bit");

                    b.Property<string>("BookingStartDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasCarPark")
                        .HasColumnType("bit");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.HasKey("BookingID");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("Assignment2.Models.CarPark", b =>
                {
                    b.Property<int>("CarParkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarParkID"), 1L, 1);

                    b.Property<string>("CarParkCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CarParkIsAvailable")
                        .HasColumnType("bit");

                    b.HasKey("CarParkID");

                    b.ToTable("CarPark");
                });

            modelBuilder.Entity("Assignment2.Models.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyID"), 1L, 1);

                    b.Property<string>("CompanyEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyID");

                    b.ToTable("Company");

                    b.HasData(
                        new
                        {
                            CompanyID = 1,
                            CompanyEmail = "cheesus@gmail.com",
                            CompanyName = "Cheesus",
                            CompanyPhone = "0272945223"
                        },
                        new
                        {
                            CompanyID = 2,
                            CompanyEmail = "penguin@gmail.com",
                            CompanyName = "Penguin",
                            CompanyPhone = "0278756754"
                        },
                        new
                        {
                            CompanyID = 3,
                            CompanyEmail = "falafal@gmail.com",
                            CompanyName = "Falafal",
                            CompanyPhone = "0279439596"
                        },
                        new
                        {
                            CompanyID = 4,
                            CompanyEmail = "kdawg@gmail.com",
                            CompanyName = "Kyle Industries",
                            CompanyPhone = "0274206969"
                        });
                });

            modelBuilder.Entity("Assignment2.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"), 1L, 1);

                    b.Property<int?>("CompanyID")
                        .HasColumnType("int");

                    b.Property<string>("CustomerFirstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerLastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TravelAgencyID")
                        .HasColumnType("int");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Assignment2.Models.Hotel", b =>
                {
                    b.Property<int>("HotelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelID"), 1L, 1);

                    b.Property<string>("HotelAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelSuburb")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HotelID");

                    b.ToTable("Hotel");

                    b.HasData(
                        new
                        {
                            HotelID = 1,
                            HotelAddress = "16 Calvin St",
                            HotelCity = "Invercargill",
                            HotelName = "Sticky Hotel",
                            HotelSuburb = "Appleby"
                        },
                        new
                        {
                            HotelID = 2,
                            HotelAddress = "11 kernel St",
                            HotelCity = "Dunedin",
                            HotelName = "Buster Hotel",
                            HotelSuburb = "Sarspry"
                        });
                });

            modelBuilder.Entity("Assignment2.Models.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomID"), 1L, 1);

                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<decimal>("RoomDailyCost")
                        .HasColumnType("decimal(12,2)");

                    b.Property<string>("RoomStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomID");

                    b.ToTable("Room");

                    b.HasData(
                        new
                        {
                            RoomID = 1,
                            HotelID = 1,
                            RoomDailyCost = 200m,
                            RoomStatus = "Vacant Clean",
                            RoomType = "Single"
                        },
                        new
                        {
                            RoomID = 2,
                            HotelID = 1,
                            RoomDailyCost = 200m,
                            RoomStatus = "Vacant Clean",
                            RoomType = "Single"
                        },
                        new
                        {
                            RoomID = 3,
                            HotelID = 1,
                            RoomDailyCost = 200m,
                            RoomStatus = "Vacant Clean",
                            RoomType = "Two Bedroom"
                        },
                        new
                        {
                            RoomID = 4,
                            HotelID = 1,
                            RoomDailyCost = 250m,
                            RoomStatus = "Vacant Clean",
                            RoomType = "Superior"
                        },
                        new
                        {
                            RoomID = 5,
                            HotelID = 1,
                            RoomDailyCost = 200m,
                            RoomStatus = "Vacant Dirty",
                            RoomType = "Two Bedroom"
                        },
                        new
                        {
                            RoomID = 6,
                            HotelID = 1,
                            RoomDailyCost = 250m,
                            RoomStatus = "Occupied Clean",
                            RoomType = "Superior"
                        },
                        new
                        {
                            RoomID = 7,
                            HotelID = 2,
                            RoomDailyCost = 250m,
                            RoomStatus = "Vacant Clean",
                            RoomType = "Single"
                        },
                        new
                        {
                            RoomID = 8,
                            HotelID = 2,
                            RoomDailyCost = 250m,
                            RoomStatus = "Vacant Clean",
                            RoomType = "Two Bedroom"
                        },
                        new
                        {
                            RoomID = 9,
                            HotelID = 2,
                            RoomDailyCost = 250m,
                            RoomStatus = "Vacant Clean",
                            RoomType = "Two Bedroom"
                        },
                        new
                        {
                            RoomID = 10,
                            HotelID = 2,
                            RoomDailyCost = 250m,
                            RoomStatus = "Vacant Clean",
                            RoomType = "Superior"
                        },
                        new
                        {
                            RoomID = 11,
                            HotelID = 2,
                            RoomDailyCost = 300m,
                            RoomStatus = "Occupied Service",
                            RoomType = "Two Bedroom"
                        },
                        new
                        {
                            RoomID = 12,
                            HotelID = 2,
                            RoomDailyCost = 300m,
                            RoomStatus = "Maintenance",
                            RoomType = "Superior"
                        });
                });

            modelBuilder.Entity("Assignment2.Models.TravelAgency", b =>
                {
                    b.Property<int>("TravelAgencyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TravelAgencyID"), 1L, 1);

                    b.Property<string>("TravelAgencyEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TravelAgencyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TravelAgencyPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TravelAgencyID");

                    b.ToTable("TravelAgency");

                    b.HasData(
                        new
                        {
                            TravelAgencyID = 1,
                            TravelAgencyEmail = "superagencyltd@gmail.com",
                            TravelAgencyName = "Super Agency Ltd",
                            TravelAgencyPhone = "0272484567"
                        },
                        new
                        {
                            TravelAgencyID = 2,
                            TravelAgencyEmail = "coolagency@gmail.com",
                            TravelAgencyName = "Cool Agency",
                            TravelAgencyPhone = "0275427567"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Assignment2.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Assignment2.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment2.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Assignment2.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
