namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectUserNotificationName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.UserNotifcations", newName: "UserNotifications");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.UserNotifications", newName: "UserNotifcations");
        }
    }
}
