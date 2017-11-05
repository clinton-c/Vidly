namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedDefaultUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9423ebba-d7a8-4ebe-bdf7-adce29c8dae8', N'admin@vidly.com', 0, N'AFGQUBkHk0QxCIEYZxwut+G4Y2yI2PvDzU4v0kjPTX6sjROz7sz/1ueNFfBQ5z1+hg==', N'1e9b9d95-f677-4b47-8f92-4f79f8409c85', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e2e3e927-72dd-4a83-80ad-24b7d4b5bbf9', N'staffer_1@vidly.com', 0, N'APXgVASwPEWsepthF/wJoHnBEFKFTBtsCLI8KxKhYSF7qMBMhyqBznGJ1GbznWHWUw==', N'95d41dff-8662-4022-ac0d-15cbcdd461a4', NULL, 0, 0, NULL, 1, 0, N'staffer_1@vidly.com')
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c2c2fb49-bbc8-4762-8495-7cbd94b27e5a', N'CanManageMovies')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9423ebba-d7a8-4ebe-bdf7-adce29c8dae8', N'c2c2fb49-bbc8-4762-8495-7cbd94b27e5a')");


        }

        public override void Down()
        {
        }
    }
}
