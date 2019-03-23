namespace Dareurbody.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addreservationtable2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "Request_sub_time", c => c.DateTime(nullable: false));
            DropColumn("dbo.Reservations", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "MyProperty", c => c.DateTime(nullable: false));
            DropColumn("dbo.Reservations", "Request_sub_time");
        }
    }
}
