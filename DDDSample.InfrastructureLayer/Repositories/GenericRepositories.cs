using DDDSample.InfrastructureLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DDDSample.InfrastructureLayer.Repositories
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : class
    {
        private readonly SurveyContext _dbContext;
        private readonly IDbSet<TEntity> _dbset;

        public GenericRepository(Uow.IUnitOfWork<SurveyContext> unitOfWork)
        {
            // _dbContext = context;
            _dbContext = unitOfWork.Context;
            _dbset = _dbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbset;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }
            else
            {
                return query;
            }
        }


        public void Delete(TKey id)
        {
            var deletedItem = Find(id);
            _dbset.Remove(deletedItem);
        }

        public TEntity Find(TKey id)
        {
            return _dbset.Find(id);
        }

        public void Insert(TEntity entity)
        {
            _dbset.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _dbset.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

    }
}
