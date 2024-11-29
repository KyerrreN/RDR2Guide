using Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext context;
        protected RepositoryBase(RepositoryContext context)
        {
            this.context = context;
        }
        public void Create(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll(bool trackChanges)
        {
            if (trackChanges)
            {
                return context
                    .Set<T>()
                    .AsNoTracking();
            }

            return context.Set<T>();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            if (trackChanges)
            {
                return context
                    .Set<T>()
                    .Where(expression)
                    .AsNoTracking();
            }

            return context
                    .Set<T>()
                    .Where(expression);
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }
    }
}
