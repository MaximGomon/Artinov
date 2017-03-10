using System.Data.Entity;
using System.Linq;
using Artinov.StageOne.DbEntity;

namespace Artinov.StageOne.DataAccess
{
    public class OrderRepository : BaseRepository<Order>
    {
        public override IQueryable<Order> GetAll()
        {
            return base.GetAll()
                .Include(x => x.Author)
                .Include(x => x.Client)
                .Include(x => x.RentTime)
                .Include(x => x.OrderElements);
        }

        public override IQueryable<Order> GetAllNotDeleted()
        {
            return base.GetAllNotDeleted()
                .Include(x => x.Author)
                .Include(x => x.Client)
                .Include(x => x.RentTime)
                .Include(x => x.OrderElements);
        }

        public override IQueryable<Order> GetAllDeleted()
        {
            return base.GetAllDeleted()
                .Include(x => x.Author)
                .Include(x => x.Client)
                .Include(x => x.RentTime);
        }
    }
}