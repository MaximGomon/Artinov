using System.Data.Entity;
using System.Linq;
using Artinov.StageOne.DbEntity;

namespace Artinov.StageOne.DataAccess
{
    public class SkiCentreRepository : BaseRepository<SkiCenter>
    {
        public override IQueryable<SkiCenter> GetAll()
        {
            return base.GetAll()
                .Include(x => x.Warehouses);
        }

        public override IQueryable<SkiCenter> GetAllNotDeleted()
        {
            return base.GetAllNotDeleted()
                .Include(x => x.Warehouses);
        }

        public override IQueryable<SkiCenter> GetAllDeleted()
        {
            return base.GetAllDeleted()
                .Include(x => x.Warehouses);
        }

        public IQueryable<SkiCenter> GetByName(string name)
        {
            return GetAll().Where(x => x.Name.Contains(name));
        }
    }
}