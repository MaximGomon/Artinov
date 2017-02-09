namespace StartWithWindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnimalType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AnimalTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 200),
                        Parent_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AnimalTypes", t => t.Parent_Id)
                .Index(t => t.Parent_Id);
            
            AddColumn("dbo.Animals", "Type_Id", c => c.Guid());
            CreateIndex("dbo.Animals", "Type_Id");
            AddForeignKey("dbo.Animals", "Type_Id", "dbo.AnimalTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animals", "Type_Id", "dbo.AnimalTypes");
            DropForeignKey("dbo.AnimalTypes", "Parent_Id", "dbo.AnimalTypes");
            DropIndex("dbo.AnimalTypes", new[] { "Parent_Id" });
            DropIndex("dbo.Animals", new[] { "Type_Id" });
            DropColumn("dbo.Animals", "Type_Id");
            DropTable("dbo.AnimalTypes");
        }
    }
}
