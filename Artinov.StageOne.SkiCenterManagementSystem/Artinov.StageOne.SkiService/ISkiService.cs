﻿using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Web.UI.WebControls;
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
        List<WarehouseElement> GetQuipmentByWarehouseId(Guid skiCentreId, Guid warehouseId);

        [OperationContract]
        List<ClientModel> GetClients();

        [OperationContract]
        List<Order> GetOrders(int count = 20, int skip = 0);

        [OperationContract]
        List<Order> GetOrdersByPeriod(DateTime stardDate, DateTime endDate);

        [OperationContract]
        List<Document> GetDocumentsByClientId(Guid clientId);

        [OperationContract]
        List<WarehouseElement> GetCurrentEquipmentsByClientId(Guid clientId);

        [OperationContract]
        List<WarehouseElement> GetCurrentRentEquipments(Guid skiCentreId);

        [OperationContract]
        List<WarehouseElement> GetCurrentFreeEquipments(Guid skiCentreId);

        [OperationContract]
        BigClient GetDetailClientInfo(Guid clientId);

        [OperationContract]
        void AddSkiCentre(SkiCenter item);

        [OperationContract]
        bool CheckUser(string login, string password);

        [OperationContract]
        void AddClient(BigClient newClient);

        [OperationContract]
        void AddOrder(Order newOrder, Guid skiCentreId);

        [OperationContract]
        void AddEquipment(Equipment newitem, int count, Guid warehouseId);

        [OperationContract]
        void AddWarehouse(Guid skicentreId, string name);

        [OperationContract]
        void DeleteClient(Guid clientId);

        [OperationContract]
        List<Phone> GetClientPhone(Guid clientId);

        [OperationContract]
        void DeletePhone(Guid phoneId);

        [OperationContract]
        void DeleteChildren(Guid childId);

        [OperationContract]
        void DeleteDocument(Guid documentId);

        [OperationContract]
        List<ClientModel> GetClientLikeName(string name);

        [OperationContract]
        List<EquipmentType> GetEquipmentTypes();

        [OperationContract]
        List<EquipmentModel> GetEqiupmentsByTypeId(Guid typeId);

        [OperationContract]
        void CreateOrderDraft(Guid orderId);
    }
}
