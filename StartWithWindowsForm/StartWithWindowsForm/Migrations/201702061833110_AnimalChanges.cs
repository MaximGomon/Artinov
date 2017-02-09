namespace StartWithWindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnimalChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "CreateDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Animals", "Name", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Animals", "Name", c => c.String());
            DropColumn("dbo.Animals", "CreateDate");
        }
    }
}
