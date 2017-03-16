using System;
using System.Collections.Generic;
using System.Linq;
using Artinov.StageOne.DataAccess;
using Artinov.StageOne.DbEntity;

namespace Artinov.StageOne.Logic
{
    public class ClientBusinessLogic : BaseBusinessLogic<BigClient, ClientRepository>
    {
        public int AddChildren(IEnumerable<LittleClient> children, Guid clientId)
        {
            var client = Repository.GetById(clientId);
            int childrenCount = 0;

            foreach (var littleClient in children)
            {
                if (littleClient.Age <= 18)
                {
                    childrenCount++;
                    client?.Childs.Add(littleClient);
                }
            }

            Repository.Update(client);
            return childrenCount;
        }

        public void AddDocument(Document document, Guid clientId)
        {
            var client = Repository.GetById(clientId);
            client?.Documents.Add(document);
            Repository.Update(client);
        }

        public List<Document> GetClientDocuments(Guid clientId)
        {
            var client = Repository.GetById(clientId);
            return client?.Documents.ToList();
        }

        public List<Phone> GetClientPhones(Guid clientId)
        {
            var client = Repository.GetById(clientId);
            return client?.Phones.ToList();
        }

        public List<WarehouseElement> GetClientRentEquipment(Guid clientId)
        {
            return Repository.GetRentEqipmentsByClientId(clientId);
        }

        public IQueryable<BigClient> GetClients()
        {
            return Repository.GetAllNotDeleted();
        }

        public void AddPhone(Guid clientId, string phone)
        {
            var client = Repository.GetById(clientId);
            client?.Phones.Add(new Phone
            {
                Name = phone
            });
            Repository.Update(client);
        }

        public void DeleteClient(Guid clientId)
        {
            var client = Repository.GetById(clientId);
            client.IsDeleted = true;
            Repository.Update(client);
        }

        public void DeleteChildren(Guid childrenId)
        {
            var logic = new BaseBusinessLogic<LittleClient, BaseRepository<LittleClient>>();
            var child = logic.GetById(childrenId);
            child.IsDeleted = true;
            logic.Update(child);
        }

        public void DeleteDocument(Guid documentId)
        {
            var logic = new BaseBusinessLogic<Document, BaseRepository<Document>>();
            var document = logic.GetById(documentId);
            document.IsDeleted = true;
            logic.Update(document);
        }

        public void DeletePhone(Guid phoneId)
        {
            var logic = new BaseBusinessLogic<Phone, BaseRepository<Phone>>();
            var phone = logic.GetById(phoneId);
            phone.IsDeleted = true;
            logic.Update(phone);
        }
    }
}