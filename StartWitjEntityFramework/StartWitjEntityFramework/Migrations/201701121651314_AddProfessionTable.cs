namespace StartWithEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProfessionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Professions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.People", "Profession_Id", c => c.Int());
            CreateIndex("dbo.People", "Profession_Id");
            AddForeignKey("dbo.People", "Profession_Id", "dbo.Professions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Profession_Id", "dbo.Professions");
            DropIndex("dbo.People", new[] { "Profession_Id" });
            DropColumn("dbo.People", "Profession_Id");
            DropTable("dbo.Professions");
        }
    }
}
