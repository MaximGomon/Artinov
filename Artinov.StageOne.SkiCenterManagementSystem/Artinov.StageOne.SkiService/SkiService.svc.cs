using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using Artinov.StageOne.DataAccess;
using Artinov.StageOne.DbEntity;
using Artinov.StageOne.Logic;

namespace Artinov.StageOne.SkiService
{
    public class SkiService : ISkiService
    {
        private readonly SkiCentreBusinessLogic _skiLogic = new SkiCentreBusinessLogic();

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
            return _skiLogic.Order.GetAll().OrderBy(x => x.CreateDate).Skip(skip).Take(count).ToList();
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

        public bool CheckUser(string login, string password)
        {
            BaseBusinessLogic<User, BaseRepository<User>> userLogic = new BaseBusinessLogic<User, BaseRepository<User>>();
            var user = userLogic.Get(x => x.Login == login && x.Password == password).FirstOrDefault();
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

        public void DeleteClient(Guid clientId)
        {
            _skiLogic.Client.DeleteClient(clientId);
        }

        public List<Phone> GetClientPhone(Guid clientId)
        {
            return _skiLogic.Client.GetClientPhones(clientId);
        }

        public void DeletePhone(Guid phoneId)
        {
            _skiLogic.Client.DeletePhone(phoneId);
        }

        public void DeleteChildren(Guid childId)
        {
            _skiLogic.Client.DeleteChildren(childId);
        }

        public void DeleteDocument(Guid documentId)
        {
            _skiLogic.Client.DeleteDocument(documentId);
        }

        public List<ClientModel> GetClientLikeName(string name)
        {
            var clients = _skiLogic.Client.Get(x => x.Name.Contains(name));
            return clients.Select(w => new ClientModel
            {
                Name = w.Name,
                Sex = w.Sex.ToString(),
                Id = w.Id,
                Age = w.Age.ToString()
            }).ToList();
        }

        public List<EquipmentType> GetEquipmentTypes()
        {
            var equipmentLogic = new BaseBusinessLogic<EquipmentType, BaseRepository<EquipmentType>>();
            return equipmentLogic.GetAll().ToList();
        }

        public List<EquipmentModel> GetEqiupmentsByTypeId(Guid typeId)
        {
            //_skiLogic.GetFreeEquipment()
            throw new NotImplementedException();
        }

        public void CreateOrderDraft(Guid orderId)
        {
            _skiLogic.CreateDraftOrder(orderId);
        }
    }
}
