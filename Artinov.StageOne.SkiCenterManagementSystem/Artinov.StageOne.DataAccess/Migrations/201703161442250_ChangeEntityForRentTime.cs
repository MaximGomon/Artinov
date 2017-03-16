namespace Artinov.StageOne.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeEntityForRentTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WarehouseElements", "RentTime", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "RentTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "RentTime", c => c.Int(nullable: false));
            DropColumn("dbo.WarehouseElements", "RentTime");
        }
    }
}
