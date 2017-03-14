using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Artinov.StageOne.DbEntity;

namespace Artinov.StageOne.DataAccess
{
    public class ClientRepository : BaseRepository<BigClient>
    {
        public override IQueryable<BigClient> GetAll()
        {
            return Context.BigClients
                .Include(x => x.Childs)
                .Include(x => x.Documents)
                .Include(x => x.Phones)
                .Include(x => x.RentEquipments);
        }

        public List<WarehouseElement> GetRentEqipmentsByClientId(Guid clientId)
        {
            return Context.BigClients
                .Include(x => x.RentEquipments)
                .FirstOrDefault(x => x.Id == clientId)?
                .RentEquipments
                .ToList();
        }

        public override BigClient GetById(Guid id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }
    }
}