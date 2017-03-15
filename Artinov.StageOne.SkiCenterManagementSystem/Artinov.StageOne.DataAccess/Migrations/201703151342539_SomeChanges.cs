namespace Artinov.StageOne.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "SkiCenter_Id", c => c.Guid());
            AddColumn("dbo.WarehouseElements", "BigClient_Id", c => c.Guid());
            CreateIndex("dbo.WarehouseElements", "BigClient_Id");
            CreateIndex("dbo.Orders", "SkiCenter_Id");
            AddForeignKey("dbo.WarehouseElements", "BigClient_Id", "dbo.Clients", "Id");
            AddForeignKey("dbo.Orders", "SkiCenter_Id", "dbo.SkiCenters", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "SkiCenter_Id", "dbo.SkiCenters");
            DropForeignKey("dbo.WarehouseElements", "BigClient_Id", "dbo.Clients");
            DropIndex("dbo.Orders", new[] { "SkiCenter_Id" });
            DropIndex("dbo.WarehouseElements", new[] { "BigClient_Id" });
            DropColumn("dbo.WarehouseElements", "BigClient_Id");
            DropColumn("dbo.Orders", "SkiCenter_Id");
        }
    }
}
