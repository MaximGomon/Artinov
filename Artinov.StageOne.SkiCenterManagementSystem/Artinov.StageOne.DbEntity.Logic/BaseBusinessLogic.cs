using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Artinov.StageOne.DbEntity;
using Artinov.StageOne.DataAccess;

namespace Artinov.StageOne.Logic
{
    public class BaseBusinessLogic<TEntity, TRepository> 
        where TEntity : IdEntity 
        where TRepository : BaseRepository<TEntity>, new()
    {
        protected readonly TRepository Repository; 

        public BaseBusinessLogic()
        {
            Repository = new TRepository();
        }

        public IQueryable<TEntity> GetAll()
        {
            return Repository.GetAllNotDeleted();
        }

        public IQueryable<TEntity> GetDeleted()
        {
            return Repository.GetAllDeleted();
        }

        public TEntity GetById(Guid id)
        {
            return Repository.GetById(id);
        }

        public void Add(TEntity item)
        {
            Repository.Add(item);
        }

        public void AddRange(IEnumerable<TEntity> item)
        {
            Repository.AddRange(item);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return Repository.Get(predicate).FirstOrDefault();
        }
    }
}
