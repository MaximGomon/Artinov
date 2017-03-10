using System;
using System.Collections.Generic;
using System.Linq;
using Artinov.StageOne.DbEntity;
using Artinov.StageOne.DataAccess;

namespace Artinov.StageOne.Logic
{
    public class SkiCentreBusinessLogic: BaseBusinessLogic<SkiCenter, SkiCentreRepository>
    {
        private readonly ClientBusinessLogic _clientLogic = new ClientBusinessLogic();
        public IQueryable<SkiCenter> GetByName(string name)
        {
            return Repository.GetByName(name);
        }

        public IQueryable<Client> GetClientsOfCentreByPeriod(DateTime startDateTime, DateTime endDate)
        {
            var clients = _clientLogic.GetClients();
            return clients;
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
    }
}
