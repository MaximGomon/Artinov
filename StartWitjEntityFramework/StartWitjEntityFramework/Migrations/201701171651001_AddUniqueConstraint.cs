namespace StartWithEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUniqueConstraint : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.People", "Login", c => c.String(maxLength: 30));
            //Sql("update dbo.People set Login = SUBSTRING(convert(TEXT, NEWID()), 0 , 15)");
            CreateIndex("dbo.People", "Login", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.People", new[] { "Login" });
            DropColumn("dbo.People", "Login");
            DropColumn("dbo.People", "Age");
        }
    }
}
