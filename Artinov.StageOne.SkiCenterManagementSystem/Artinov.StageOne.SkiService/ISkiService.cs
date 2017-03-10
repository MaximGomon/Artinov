using System;
using System.Collections.Generic;
using System.ServiceModel;
using Artinov.StageOne.DbEntity;

namespace Artinov.StageOne.SkiService
{
    [ServiceContract]
    public interface ISkiService
    {
        [OperationContract]
        SkiCenter[] GetCenters();

        [OperationContract]
        List<Warehouse> GetWarehouses(Guid skiCentreId);

        [OperationContract]
        List<Equipment> GetQuipmentByWarehouseId(Guid id);

        [OperationContract]
        List<Equipment> GetQuipmentByWarehouseName(string name);

        [OperationContract]
        List<Client> GetClients();

        [OperationContract]
        List<Order> GetOrders(int count, int skip = 0);

        [OperationContract]
        List<Order> GetOrdersByPeriod(DateTime stardDate, DateTime endDate);

        [OperationContract]
        List<Document> GetDocumentsByClientId(Guid clientId);

        [OperationContract]
        List<Equipment> GetCurrentEquipmentsByClientId(Guid clientId);

        [OperationContract]
        List<Equipment> GetCurrentRentEquipments();

        [OperationContract]
        Client GetDetailClientInfo(Guid clientId);

        [OperationContract]
        void AddSkiCentre(SkiCenter item);

        [OperationContract]
        void AddWarehouseToSkiCentre(Guid skiCenterId, Warehouse item);

        [OperationContract]
        bool CheckUser(string login, string password);
    }
}
