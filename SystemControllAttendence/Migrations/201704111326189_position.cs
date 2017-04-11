namespace SystemControllAttendence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class position : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personnels", "Position", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Personnels", "Position");
        }
    }
}
