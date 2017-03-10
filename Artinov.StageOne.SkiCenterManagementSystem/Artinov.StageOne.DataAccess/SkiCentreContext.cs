using System.Data.Entity;
using Artinov.StageOne.DbEntity;

namespace Artinov.StageOne.DataAccess
{
    public class SkiCentreContext : DbContext
    {
        public SkiCentreContext() : base("DbConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
        
        public DbSet<BigClient> BigClients { get; set; }
        public DbSet<LittleClient> LittleClients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<WarehouseElement> WarehouseElements { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<SkiCenter> SkiCenters { get; set; }
    }
}
