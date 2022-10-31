using Assignment2.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Assignment2.Models;

namespace Assignment2.Data;

public class Assignment2Context : IdentityDbContext<ApplicationUser>
{
    public Assignment2Context(DbContextOptions<Assignment2Context> options)
        : base(options)
    {
    }

    public DbSet<Booking> Booking { get; set; }
    public DbSet<CarPark> CarPark { get; set; }
    public DbSet<Company> Company { get; set; }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Hotel> Hotel { get; set; }
    public DbSet<Room> Room { get; set; }
    public DbSet<TravelAgency> TravelAgency { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());

        // -------------------------------------------------- Company --------------------------------------------------
        builder.Entity<Company>().HasData(
            new Company()
            {
                CompanyID = 1,
                CompanyName = "Cheesus",
                CompanyEmail = "cheesus@gmail.com",
                CompanyPhone = "0272945223"
            },
            new Company()
            {
                CompanyID = 2,
                CompanyName = "Penguin",
                CompanyEmail = "penguin@gmail.com",
                CompanyPhone = "0278756754"
            },
            new Company()
            {
                CompanyID = 3,
                CompanyName = "Falafal",
                CompanyEmail = "falafal@gmail.com",
                CompanyPhone = "0279439596"
            },
            new Company()
            {
                CompanyID = 4,
                CompanyName = "Kyle Industries",
                CompanyEmail = "kdawg@gmail.com",
                CompanyPhone = "0274206969"
            }
        );
        // -------------------------------------------------- TravelAgency --------------------------------------------------
        builder.Entity<TravelAgency>().HasData(
            new TravelAgency()
            {
                TravelAgencyID = 1,
                TravelAgencyName = "Super Agency Ltd",
                TravelAgencyEmail = "superagencyltd@gmail.com",
                TravelAgencyPhone = "0272484567"
            },
            new TravelAgency()
            {
                TravelAgencyID = 2,
                TravelAgencyName = "Cool Agency",
                TravelAgencyEmail = "coolagency@gmail.com",
                TravelAgencyPhone = "0275427567"
            }
        );
        // -------------------------------------------------- Hotel --------------------------------------------------
        builder.Entity<Hotel>().HasData(
            new Hotel()
            {
                HotelID = 1,
                HotelName = "Sticky Hotel",
                HotelCity = "Invercargill",
                HotelSuburb = "Appleby",
                HotelAddress = "16 Calvin St"
            },
            new Hotel()
            {
                HotelID = 2,
                HotelName = "Buster Hotel",
                HotelCity = "Dunedin",
                HotelSuburb = "Sarspry",
                HotelAddress = "11 kernel St"
            }
        );
        // -------------------------------------------------- Room --------------------------------------------------
        builder.Entity<Room>().HasData(
            /// -------------------- Hotel 1 --------------------
            new Room()
            {
                RoomID = 1,
                RoomDailyCost = 200M,
                RoomType = "Single",
                RoomStatus = "Vacant Clean",
                HotelID = 1
            },
            new Room()
            {
                RoomID = 2,
                RoomDailyCost = 200M,
                RoomType = "Single",
                RoomStatus = "Vacant Clean",
                HotelID = 1
            },
            new Room()
            {
                RoomID = 3,
                RoomDailyCost = 200M,
                RoomType = "Two Bedroom",
                RoomStatus = "Vacant Clean",
                HotelID = 1
            },
            new Room()
            {
                RoomID = 4,
                RoomDailyCost = 250M,
                RoomType = "Superior",
                RoomStatus = "Vacant Clean",
                HotelID = 1
            },
            new Room()
            {
                RoomID = 5,
                RoomDailyCost = 200M,
                RoomType = "Two Bedroom",
                RoomStatus = "Vacant Dirty",
                HotelID = 1
            },
            new Room()
            {
                RoomID = 6,
                RoomDailyCost = 250M,
                RoomType = "Superior",
                RoomStatus = "Occupied Clean",
                HotelID = 1
            },
            /// -------------------- Hotel 2 --------------------
            new Room()
            {
                RoomID = 7,
                RoomDailyCost = 250M,
                RoomType = "Single",
                RoomStatus = "Vacant Clean",
                HotelID = 2
            },
            new Room()
            {
                RoomID = 8,
                RoomDailyCost = 250M,
                RoomType = "Two Bedroom",
                RoomStatus = "Vacant Clean",
                HotelID = 2
            },
            new Room()
            {
                RoomID = 9,
                RoomDailyCost = 250M,
                RoomType = "Two Bedroom",
                RoomStatus = "Vacant Clean",
                HotelID = 2
            },
            new Room()
            {
                RoomID = 10,
                RoomDailyCost = 250M,
                RoomType = "Superior",
                RoomStatus = "Vacant Clean",
                HotelID = 2
            },
            new Room()
            {
                RoomID = 11,
                RoomDailyCost = 300M,
                RoomType = "Two Bedroom",
                RoomStatus = "Occupied Service",
                HotelID = 2
            },
            new Room()
            {
                RoomID = 12,
                RoomDailyCost = 300M,
                RoomType = "Superior",
                RoomStatus = "Maintenance",
                HotelID = 2
            }
        );
        // -------------------------------------------------- CarPark --------------------------------------------------
        //builder.Entity<CarPark>().HasData(
        //    new CarPark()
        //    {
        //        CarParkID = 1,
        //        CarParkCode = "43U",
        //        CarParkIsAvailable = false
        //    },
        //    new CarPark()
        //    {
        //        CarParkID = 2,
        //        CarParkCode = "25H",
        //        CarParkIsAvailable = false
        //    },
        //    new CarPark()
        //    {
        //        CarParkID = 3,
        //        CarParkCode = "15Q",
        //        CarParkIsAvailable = true
        //    },
        //    new CarPark()
        //    {
        //        CarParkID = 4,
        //        CarParkCode = "58B",
        //        CarParkIsAvailable = true
        //    },
        //    new CarPark()
        //    {
        //        CarParkID = 5,
        //        CarParkCode = "32B",
        //        CarParkIsAvailable = true
        //    },
        //    new CarPark()
        //    {
        //        CarParkID = 6,
        //        CarParkCode = "69A",
        //        CarParkIsAvailable = true
        //    },
        //    new CarPark()
        //    {
        //        CarParkID = 7,
        //        CarParkCode = "54B",
        //        CarParkIsAvailable = true
        //    },
        //    new CarPark()
        //    {
        //        CarParkID = 8,
        //        CarParkCode = "57Y",
        //        CarParkIsAvailable = true
        //    },
        //    new CarPark()
        //    {
        //        CarParkID = 9,
        //        CarParkCode = "88F",
        //        CarParkIsAvailable = true
        //    },
        //    new CarPark()
        //    {
        //        CarParkID = 10,
        //        CarParkCode = "39R",
        //        CarParkIsAvailable = true
        //    }
        //);
    }
}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(u => u.Firstname).HasMaxLength(256);
        builder.Property(u => u.Lastname).HasMaxLength(256);
        builder.Property(u => u.Location).HasMaxLength(256);

    }
}
