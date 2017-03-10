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
        private readonly WarehouseBusinessLogic _warehouseLogic = new WarehouseBusinessLogic();

        public SkiCenter[] GetCenters()
        {
            return _skiLogic.GetAll().ToArray();
        }

        public List<Warehouse> GetWarehouses(Guid skiCentreId)
        {
            return _skiLogic.GetAllWarehousesByCentreId(skiCentreId);
        }

        public List<Equipment> GetQuipmentByWarehouseId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Equipment> GetQuipmentByWarehouseName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetClients()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders(int count, int skip = 0)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrdersByPeriod(DateTime stardDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public List<Document> GetDocumentsByClientId(Guid clientId)
        {
            throw new NotImplementedException();
        }

        public List<Equipment> GetCurrentEquipmentsByClientId(Guid clientId)
        {
            throw new NotImplementedException();
        }

        public List<Equipment> GetCurrentRentEquipments()
        {
            throw new NotImplementedException();
        }

        public Client GetDetailClientInfo(Guid clientId)
        {
            throw new NotImplementedException();
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
    }
}
