namespace SystemControllAttendence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletDeportaments : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Departaments", "ParentDepartament_Id", "dbo.Departaments");
            DropForeignKey("dbo.Departaments", "Person_Id", "dbo.Personnels");
            DropIndex("dbo.Departaments", new[] { "ParentDepartament_Id" });
            DropIndex("dbo.Departaments", new[] { "Person_Id" });
            DropTable("dbo.Departaments");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Departaments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        ParentDepartament_Id = c.Int(),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Departaments", "Person_Id");
            CreateIndex("dbo.Departaments", "ParentDepartament_Id");
            AddForeignKey("dbo.Departaments", "Person_Id", "dbo.Personnels", "Id");
            AddForeignKey("dbo.Departaments", "ParentDepartament_Id", "dbo.Departaments", "Id");
        }
    }
}
