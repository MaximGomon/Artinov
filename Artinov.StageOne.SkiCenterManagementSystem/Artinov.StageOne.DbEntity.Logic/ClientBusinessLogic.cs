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
                    client.Childs.Add(littleClient);
                }
            }

            Repository.Update(client);
            return childrenCount;
        }

        public void AddDocument(Document document, Guid clientId)
        {
            var client = Repository.GetById(clientId);
            client.Documents.Add(document);
            Repository.Update(client);
        }

        public IQueryable<BigClient> GetClients()
        {
            return Repository.GetAll();
        }

        public void AddPhone(Guid clientId, string phone)
        {
            var client = Repository.GetById(clientId);
            client.Phones.Add(new Phone
            {
                Name = phone
            });
            Repository.Update(client);
        }
    }
}