namespace Dareurbody.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addreservationtable6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "end_time", c => c.DateTime(nullable: false));
            DropColumn("dbo.Reservations", "start_time");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "start_time", c => c.DateTime(nullable: false));
            DropColumn("dbo.Reservations", "end_time");
        }
    }
}
