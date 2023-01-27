namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0011459e-5d45-4689-a847-86d247b47b6f', N'Zweitonegoismus@gmail.com', 0, N'AOVn2c12i1QSBMYNWapslpGh8oz+mJ4tUoNlVe2OcU58VK1nLCRkp0H037DjMPjgVg==', N'8e15b815-e743-4141-a331-ee7f59e7542d', NULL, 0, 0, NULL, 1, 0, N'Zweitonegoismus@gmail.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0616e3a8-e16c-4128-bce7-1ca76d266d03', N'guest@vidly.com', 0, N'AM6yoK53gyLBYes+VbV8p8mcXTl+OtvYrZgRjo4JyeKnZ9ezaUaUcnNBdqTlH3XwXQ==', N'496a1c06-0191-46d6-be38-61aa82052468', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'28744120-efbf-4bec-871a-cbe25830347f', N'admin@vidly.com', 0, N'AKsaAhWc6eNgq6SxsVv3V2w9QbGqsWhVnHXF/JEm60ACiZF5/NFUbkKIi7HdYI6cMg==', N'dcfb7380-bd84-4620-a247-e6598ecf8f4a', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            


            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [Discriminator]) VALUES (N'53baa4ad-8e34-49e6-ba07-e323f42009e1', N'CanManageMovies', N'IdentityRole')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'28744120-efbf-4bec-871a-cbe25830347f', N'53baa4ad-8e34-49e6-ba07-e323f42009e1')


            ");
        }
        
        public override void Down()
        {
        }
    }
}
