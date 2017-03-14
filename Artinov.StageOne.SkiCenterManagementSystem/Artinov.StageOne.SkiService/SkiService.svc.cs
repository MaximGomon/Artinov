using System;
using System.Collections.Generic;
using System.Linq;
using Artinov.StageOne.DataAccess;
using Artinov.StageOne.DbEntity;
using Artinov.StageOne.Logic;

namespace Artinov.StageOne.SkiService
{
    public class SkiService : ISkiService
    {
        private readonly SkiCentreBusinessLogic _skiLogic = new SkiCentreBusinessLogic();
        private readonly OrderBusinessLogic _orderLogic = new OrderBusinessLogic();

        public SkiCenter[] GetCenters()
        {
            return _skiLogic.GetAll().ToArray();
        }

        public List<Warehouse> GetWarehouses(Guid skiCentreId)
        {
            return _skiLogic.GetAllWarehousesByCentreId(skiCentreId);
        }

        public List<WarehouseElement> GetQuipmentByWarehouseId(Guid skiCentreId, Guid warehouseId)
        {
            return _skiLogic.GetFreeEquipmentByWarehouseId(skiCentreId, warehouseId);
        }

        public List<ClientModel> GetClients()
        {
            return _skiLogic.Client.GetClients().Select(x => new ClientModel
            {
              Name  = x.Name,
              Age = x.Age.ToString(),
              Sex = x.Sex.ToString(),
              Id = x.Id
            }).ToList();
        }

        public List<Order> GetOrders(int count = 20, int skip = 0)
        {
            return _orderLogic.GetAll().Skip(skip).Take(count).ToList();
        }

        public List<Order> GetOrdersByPeriod(DateTime stardDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public List<Document> GetDocumentsByClientId(Guid clientId)
        {
            return _skiLogic.Client.GetClientDocuments(clientId);
        }

        public List<WarehouseElement> GetCurrentEquipmentsByClientId(Guid clientId)
        {
            return _skiLogic.Client.GetClientRentEquipment(clientId);
        }

        public List<WarehouseElement> GetCurrentRentEquipments(Guid skiCentreId)
        {
            return _skiLogic.GetRentEquipment(skiCentreId);
        }

        public List<WarehouseElement> GetCurrentFreeEquipments(Guid skiCentreId)
        {
            return _skiLogic.GetFreeEquipment(skiCentreId);
        }

        public BigClient GetDetailClientInfo(Guid clientId)
        {
            return _skiLogic.Client.GetById(clientId);
        }

        public void AddSkiCentre(SkiCenter item)
        {
            _skiLogic.Add(item);
        }

        public void AddWarehouseToSkiCentre(Guid skiCenterId, Warehouse item)
        {
            _skiLogic.AddWarehouseToCentre(skiCenterId, item);
        }

        public bool CheckUser(string login, string password)
        {
            BaseBusinessLogic<User, BaseRepository<User>> userLogic = new BaseBusinessLogic<User, BaseRepository<User>>();
            var user = userLogic.Get(x => x.Login == login && x.Password == password);
            return user != null;
        }

        public void AddClient(BigClient newClient)
        {
            _skiLogic.Client.Add(newClient);
        }

        public void AddOrder(Order newOrder, Guid skiCentreId)
        {
            _skiLogic.AddOrder(newOrder, skiCentreId);
        }

        public void AddEquipment(Equipment newitem, int count, Guid warehouseId)
        {
            _skiLogic.AddItemToWarehouse(newitem, count, warehouseId);
        }

        public void AddWarehouse(Guid skicentreId, string name)
        {
            _skiLogic.AddWarehouseToCentre(skicentreId, new Warehouse
            {
                Name = name
            });
        }
    }
}
