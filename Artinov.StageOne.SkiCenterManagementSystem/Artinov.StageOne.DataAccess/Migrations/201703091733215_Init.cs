namespace Artinov.StageOne.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Age = c.Int(nullable: false),
                        Sex = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 500),
                        IsDeleted = c.Boolean(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        BigClient_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.BigClient_Id)
                .Index(t => t.BigClient_Id);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Series = c.String(nullable: false, maxLength: 5),
                        Number = c.String(nullable: false, maxLength: 20),
                        Name = c.String(nullable: false, maxLength: 500),
                        IsDeleted = c.Boolean(nullable: false),
                        BigClient_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.BigClient_Id)
                .Index(t => t.BigClient_Id);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 500),
                        IsDeleted = c.Boolean(nullable: false),
                        BigClient_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.BigClient_Id)
                .Index(t => t.BigClient_Id);
            
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Size = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 500),
                        IsDeleted = c.Boolean(nullable: false),
                        Type_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EquipmentTypes", t => t.Type_Id, cascadeDelete: true)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.EquipmentTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Code = c.Int(nullable: false),
                        Description = c.String(maxLength: 1000),
                        Name = c.String(nullable: false, maxLength: 500),
                        IsDeleted = c.Boolean(nullable: false),
                        ParentEquipmentType_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EquipmentTypes", t => t.ParentEquipmentType_Id)
                .Index(t => t.ParentEquipmentType_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Number = c.String(nullable: false, maxLength: 20),
                        Cost = c.Double(nullable: false),
                        RentTime = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Author_Id = c.Guid(nullable: false),
                        Client_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Author_Id, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_Id, cascadeDelete: true)
                .Index(t => t.Author_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Login = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 100),
                        Role = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 500),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WarehouseElements",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Count = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Equipment_Id = c.Guid(nullable: false),
                        Order_Id = c.Guid(),
                        Warehouse_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Equipments", t => t.Equipment_Id, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .ForeignKey("dbo.Warehouses", t => t.Warehouse_Id)
                .Index(t => t.Equipment_Id)
                .Index(t => t.Order_Id)
                .Index(t => t.Warehouse_Id);
            
            CreateTable(
                "dbo.SkiCenters",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 500),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 500),
                        IsDeleted = c.Boolean(nullable: false),
                        SkiCenter_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SkiCenters", t => t.SkiCenter_Id)
                .Index(t => t.SkiCenter_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Warehouses", "SkiCenter_Id", "dbo.SkiCenters");
            DropForeignKey("dbo.WarehouseElements", "Warehouse_Id", "dbo.Warehouses");
            DropForeignKey("dbo.WarehouseElements", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.WarehouseElements", "Equipment_Id", "dbo.Equipments");
            DropForeignKey("dbo.Orders", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Orders", "Author_Id", "dbo.Users");
            DropForeignKey("dbo.Equipments", "Type_Id", "dbo.EquipmentTypes");
            DropForeignKey("dbo.EquipmentTypes", "ParentEquipmentType_Id", "dbo.EquipmentTypes");
            DropForeignKey("dbo.Phones", "BigClient_Id", "dbo.Clients");
            DropForeignKey("dbo.Documents", "BigClient_Id", "dbo.Clients");
            DropForeignKey("dbo.Clients", "BigClient_Id", "dbo.Clients");
            DropIndex("dbo.Warehouses", new[] { "SkiCenter_Id" });
            DropIndex("dbo.WarehouseElements", new[] { "Warehouse_Id" });
            DropIndex("dbo.WarehouseElements", new[] { "Order_Id" });
            DropIndex("dbo.WarehouseElements", new[] { "Equipment_Id" });
            DropIndex("dbo.Orders", new[] { "Client_Id" });
            DropIndex("dbo.Orders", new[] { "Author_Id" });
            DropIndex("dbo.EquipmentTypes", new[] { "ParentEquipmentType_Id" });
            DropIndex("dbo.Equipments", new[] { "Type_Id" });
            DropIndex("dbo.Phones", new[] { "BigClient_Id" });
            DropIndex("dbo.Documents", new[] { "BigClient_Id" });
            DropIndex("dbo.Clients", new[] { "BigClient_Id" });
            DropTable("dbo.Warehouses");
            DropTable("dbo.SkiCenters");
            DropTable("dbo.WarehouseElements");
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.EquipmentTypes");
            DropTable("dbo.Equipments");
            DropTable("dbo.Phones");
            DropTable("dbo.Documents");
            DropTable("dbo.Clients");
        }
    }
}
