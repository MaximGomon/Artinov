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

        public override IQueryable<BigClient> GetAllNotDeleted()
        {
            return Context.BigClients
                .Include(x => x.Childs)
                .Include(x => x.Documents)
                .Include(x => x.Phones)
                .Include(x => x.RentEquipments)
                .Where(x => x.IsDeleted == false 
                    && x.Childs.All(w => w.IsDeleted == false)
                    && x.Documents.All(w => w.IsDeleted == false)
                    && x.Phones.All(w => w.IsDeleted == false)
                    && x.RentEquipments.All(w => w.IsDeleted == false));
        }

        public List<WarehouseElement> GetRentEqipmentsByClientId(Guid clientId)
        {
            return Context.BigClients
                .Include(x => x.RentEquipments.Where(w => w.IsDeleted == false))
                .FirstOrDefault(x => x.Id == clientId)?
                .RentEquipments
                .ToList();
        }

        public override BigClient GetById(Guid id)
        {
            return GetAllNotDeleted().FirstOrDefault(x => x.Id == id);
        }
    }
}