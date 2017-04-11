namespace SystemControllAttendence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DayWeek = c.String(),
                        LoginTime = c.DateTime(),
                        OutTime = c.DateTime(),
                        Personnel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personnels", t => t.Personnel_Id)
                .Index(t => t.Personnel_Id);
            
            CreateTable(
                "dbo.Personnels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        MiddleName = c.String(),
                        Photo = c.Binary(storeType: "image"),
                    })
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departaments", t => t.ParentDepartament_Id)
                .ForeignKey("dbo.Personnels", t => t.Person_Id)
                .Index(t => t.ParentDepartament_Id)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Name = c.String(),
                        Personnel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personnels", t => t.Personnel_Id)
                .Index(t => t.Personnel_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Photo = c.Binary(storeType: "image"),
                        Login = c.String(),
                        Password = c.String(),
                        email = c.String(),
                        roles = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Documents", "Personnel_Id", "dbo.Personnels");
            DropForeignKey("dbo.Departaments", "Person_Id", "dbo.Personnels");
            DropForeignKey("dbo.Departaments", "ParentDepartament_Id", "dbo.Departaments");
            DropForeignKey("dbo.Attendances", "Personnel_Id", "dbo.Personnels");
            DropIndex("dbo.Documents", new[] { "Personnel_Id" });
            DropIndex("dbo.Departaments", new[] { "Person_Id" });
            DropIndex("dbo.Departaments", new[] { "ParentDepartament_Id" });
            DropIndex("dbo.Attendances", new[] { "Personnel_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Documents");
            DropTable("dbo.Departaments");
            DropTable("dbo.Personnels");
            DropTable("dbo.Attendances");
        }
    }
}
