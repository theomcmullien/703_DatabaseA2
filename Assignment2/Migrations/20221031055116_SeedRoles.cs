using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment2.Migrations
{
    public partial class SeedRoles : Migration
    {
        private string ManagerRoleId = Guid.NewGuid().ToString();
        private string ReceptionRoleId = Guid.NewGuid().ToString();
        private string HousekeeperRoleId = Guid.NewGuid().ToString();
        private string CustomerRoleId = Guid.NewGuid().ToString();

        private string User1Id = Guid.NewGuid().ToString();
        private string User2Id = Guid.NewGuid().ToString();
        private string User3Id = Guid.NewGuid().ToString();
        private string User4Id = Guid.NewGuid().ToString();

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            SeedRolesSQL(migrationBuilder);
            SeedUser(migrationBuilder);
            SeedUserRoles(migrationBuilder);
        }

        private void SeedRolesSQL(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@$"INSERT INTO [dbo].[AspNetRoles] ([Id],[Name],[NormalizedName],[ConcurrencyStamp]) VALUES ('{ManagerRoleId}', 'Manager', 'MANAGER', null);");
            migrationBuilder.Sql(@$"INSERT INTO [dbo].[AspNetRoles] ([Id],[Name],[NormalizedName],[ConcurrencyStamp]) VALUES ('{ReceptionRoleId}', 'Reception', 'RECEPTION', null);");
            migrationBuilder.Sql(@$"INSERT INTO [dbo].[AspNetRoles] ([Id],[Name],[NormalizedName],[ConcurrencyStamp]) VALUES ('{HousekeeperRoleId}', 'Housekeeper', 'HOUSEKEEPER', null);");
            migrationBuilder.Sql(@$"INSERT INTO [dbo].[AspNetRoles] ([Id],[Name],[NormalizedName],[ConcurrencyStamp]) VALUES ('{CustomerRoleId}', 'Customer', 'CUSTOMER', null);");

        }

        private void SeedUser(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@$"INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [CompanyID], [TravelAgencyID], [Location], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'{User1Id}', N'ManagerFirst', N'Lastname', 0, 0, N'Staff', N'manager@gmail.com', N'MANAGER@GMAIL.COM', N'manager@gmail.com', N'MANAGER@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEHxB7HKjg/oDV2BkrDNVDsXF4hjGD/HtMpHvLhlSWbSdqXV9xLC7Mj+1VYCV0xyihA==', N'O3HPUF7PPWPOKRQSJTDMQTP6THWEG5CT', N'fb032e9c-4787-4082-aa31-8a1e9ce2ffd5', NULL, 0, 0, NULL, 1, 0)");
            migrationBuilder.Sql(@$"INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [CompanyID], [TravelAgencyID], [Location], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'{User2Id}', N'ReceptionFirst', N'Lastname', 0, 0, N'Staff', N'reception@gmail.com', N'RECEPTION@GMAIL.COM', N'reception@gmail.com', N'RECEPTION@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEHxB7HKjg/oDV2BkrDNVDsXF4hjGD/HtMpHvLhlSWbSdqXV9xLC7Mj+1VYCV0xyihA==', N'O3HPUF7PPWPOKRQSJTDMQTP6THWEG5CT', N'fb032e9c-4787-4082-aa31-8a1e9ce2ffd5', NULL, 0, 0, NULL, 1, 0)");
            migrationBuilder.Sql(@$"INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [CompanyID], [TravelAgencyID], [Location], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'{User3Id}', N'HousekeeperFirst', N'Lastname', 0, 0, N'Staff', N'housekeeper@gmail.com', N'HOUSEKEEPER@GMAIL.COM', N'housekeeper@gmail.com', N'HOUSEKEEPER@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEHxB7HKjg/oDV2BkrDNVDsXF4hjGD/HtMpHvLhlSWbSdqXV9xLC7Mj+1VYCV0xyihA==', N'O3HPUF7PPWPOKRQSJTDMQTP6THWEG5CT', N'fb032e9c-4787-4082-aa31-8a1e9ce2ffd5', NULL, 0, 0, NULL, 1, 0)");
            migrationBuilder.Sql(@$"INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [CompanyID], [TravelAgencyID], [Location], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'{User4Id}', N'Billie', N'Eilish', 1, 1, N'Invercargill', N'customer@gmail.com', N'CUSTOMER@GMAIL.COM', N'customer@gmail.com', N'CUSTOMER@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEHxB7HKjg/oDV2BkrDNVDsXF4hjGD/HtMpHvLhlSWbSdqXV9xLC7Mj+1VYCV0xyihA==', N'O3HPUF7PPWPOKRQSJTDMQTP6THWEG5CT', N'fb032e9c-4787-4082-aa31-8a1e9ce2ffd5', NULL, 0, 0, NULL, 1, 0)");

        }

        private void SeedUserRoles(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@$"INSERT INTO [dbo].[AspNetUserRoles] ([UserId],[RoleId]) VALUES ('{User1Id}', '{ManagerRoleId}');");
            migrationBuilder.Sql(@$"INSERT INTO [dbo].[AspNetUserRoles] ([UserId],[RoleId]) VALUES ('{User2Id}', '{ReceptionRoleId}');");
            migrationBuilder.Sql(@$"INSERT INTO [dbo].[AspNetUserRoles] ([UserId],[RoleId]) VALUES ('{User3Id}', '{HousekeeperRoleId}');");
            migrationBuilder.Sql(@$"INSERT INTO [dbo].[AspNetUserRoles] ([UserId],[RoleId]) VALUES ('{User4Id}', '{CustomerRoleId}');");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
