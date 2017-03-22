using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Artinov.StageOne.DbEntity;
using Artinov.StageOne.DataAccess;

namespace Artinov.StageOne.Logic
{
    public class SkiCentreBusinessLogic: BaseBusinessLogic<SkiCenter, SkiCentreRepository>
    {
        private readonly ClientBusinessLogic _clientLogic = new ClientBusinessLogic();
        private readonly WarehouseBusinessLogic _warehouseLogic = new WarehouseBusinessLogic();
        private readonly OrderBusinessLogic _orderLogic = new OrderBusinessLogic();


        public ClientBusinessLogic Client => _clientLogic;
        public OrderBusinessLogic Order => _orderLogic;


        public List<SkiCenter> GetByName(string name)
        {
            return Repository.GetByName(name).ToList();
        }

        public List<WarehouseElement> GetRentEquipment(Guid centreId)
        {
            return Repository.GetById(centreId).Orders.SelectMany(x => x.OrderElements).ToList();
        }

        public List<WarehouseElement> GetFreeEquipment(Guid centreId)
        {
            return Repository.GetById(centreId).Warehouses.SelectMany(x => x.Equipments).ToList();
        }

        public List<WarehouseElement> GetFreeEquipmentByWarehouseId(Guid centreId, Guid warehouseId)
        {
            return Repository.GetById(centreId).Warehouses.FirstOrDefault(x => x.Id == warehouseId)?.Equipments.ToList();
        }

        public List<Warehouse> GetAllWarehousesByCentreId(Guid centreId)
        {
            return Repository.GetById(centreId).Warehouses.ToList();
        }

        public void AddWarehouseToCentre(Guid centerId, Warehouse item)
        {
            SkiCenter centre = Repository.GetById(centerId);
            centre.Warehouses.Add(item);
            Repository.Update(centre);
        }

        public void AddOrder(Order newOrder, Guid centreId)
        {
            var centre = Repository.GetById(centreId);
            centre.Orders.Add(newOrder);
            Repository.Update(centre);
        }

        public void AddItemToWarehouse(Equipment newitem, int count, Guid warehouseId)
        {
            var item = new WarehouseElement
            {
                Count = count,
                Equipment = newitem
            };
            var wareohuse = _warehouseLogic.GetById(warehouseId);
            wareohuse.Equipments.Add(item);
            _warehouseLogic.Update(wareohuse);
        }

        public void CreateDraftOrder(Guid orderId)
        {
            var defaultClient = _clientLogic.Get(x => x.Name == "default").First();
            _orderLogic.CreateDraftOrder(orderId, defaultClient);
        }
    }
}
