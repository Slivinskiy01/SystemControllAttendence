namespace SystemControllAttendence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deps : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departaments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        ParentId = c.Int(),
                        ParentDep_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departaments", t => t.ParentDep_Id)
                .Index(t => t.ParentDep_Id);
            
            AddColumn("dbo.Personnels", "Departaments_Id", c => c.Int());
            CreateIndex("dbo.Personnels", "Departaments_Id");
            AddForeignKey("dbo.Personnels", "Departaments_Id", "dbo.Departaments", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personnels", "Departaments_Id", "dbo.Departaments");
            DropForeignKey("dbo.Departaments", "ParentDep_Id", "dbo.Departaments");
            DropIndex("dbo.Departaments", new[] { "ParentDep_Id" });
            DropIndex("dbo.Personnels", new[] { "Departaments_Id" });
            DropColumn("dbo.Personnels", "Departaments_Id");
            DropTable("dbo.Departaments");
        }
    }
}
