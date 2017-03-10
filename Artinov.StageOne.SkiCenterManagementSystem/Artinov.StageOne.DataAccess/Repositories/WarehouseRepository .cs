using System;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Linq;
using Artinov.StageOne.DbEntity;

namespace Artinov.StageOne.DataAccess
{
    public class WarehouseRepository : BaseRepository<Warehouse>
    {
        public override IQueryable<Warehouse> GetAll()
        {
            return Context.Warehouses.Include(x => x.Equipments);
        }

        public void AddItemToWharehouse(Guid warehouseId, WarehouseElement item)
        {
            var warehouse = GetById(warehouseId);
            warehouse.Equipments.Add(item);
            Update(warehouse);
        }

        public void RemoveItemFromWharehouse(Guid warehouseId, Guid elementId)
        {
            var warehouse = GetById(warehouseId);
            var itemToDelete = warehouse.Equipments.First(x => x.Id == elementId);
            if(itemToDelete == null)
                throw new ObjectNotFoundException();
            warehouse.Equipments.Remove(itemToDelete);
            Update(warehouse);
        }
    }
}