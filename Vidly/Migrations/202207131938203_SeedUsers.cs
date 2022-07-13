namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'35a6a7be-e38f-4340-90e0-238541826ef8', N'guest@vidly.com', 0, N'AIfpjVTxrw5FV9lGg/IsY8FvbXdEPxvP8wo1PynFdjexmWRVh5PfbDmXWvvlFl8eEg==', N'bcfbeacb-870c-4aae-a07f-f9367d62c136', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'781d75c8-c8ca-4df8-b856-9938b58fd28e', N'admin@vidly.com', 0, N'ADiMG0RKfsvXxbUZkDEu1XZNDoF5P4IDr6FUe0zxggjXUViAkfklN5CTezW1n6Q9ow==', N'ebdba36b-1bba-43b3-bcbb-2be9645d2fe9', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd1be1e1c-3e1c-4735-a489-7c5281e513fb', N'CanManageMovies')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'781d75c8-c8ca-4df8-b856-9938b58fd28e', N'd1be1e1c-3e1c-4735-a489-7c5281e513fb')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
