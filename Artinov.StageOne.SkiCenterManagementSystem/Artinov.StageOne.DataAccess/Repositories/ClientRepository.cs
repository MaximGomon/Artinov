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
                .Include(x => x.Phones);
        }
    }
}