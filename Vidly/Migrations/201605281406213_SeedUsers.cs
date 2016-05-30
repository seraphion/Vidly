namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5e540dc6-59d5-4481-a8ac-33e04bd4894e', N'guest@vidly.com', 0, N'AJtFRSzx1TIvvV/pW1OjJyeN+vv3RcLzrcWSvxZ0ndsriUvFVGBdYYEtPUYwi38CmA==', N'eb25776c-d8fe-4069-9c72-ea5aeaf9800c', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b33611ea-11a9-4821-86ae-e77fbaa12bd1', N'admin@vidly.com', 0, N'AHDF1rCgBqJ5IiAYqphaT82iepXySswnM6FtDWUc2djJNnw6EBJp8FXyyscEBVscQg==', N'2d4da897-8fa6-4e5b-acd3-b45f7315d8be', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a0c64438-39cd-4155-adac-ec3300c24e9d', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b33611ea-11a9-4821-86ae-e77fbaa12bd1', N'a0c64438-39cd-4155-adac-ec3300c24e9d')
");
        }

        public override void Down()
        {
        }
    }
}
