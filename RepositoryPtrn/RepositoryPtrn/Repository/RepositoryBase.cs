using Microsoft.EntityFrameworkCore;
using RepositoryPtrn.Models;

namespace RepositoryPtrn.Repository
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal ApplicationContext context;
        internal DbSet<TEntity> dbSet;

        public RepositoryBase(ApplicationContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }
        
        public virtual TEntity GetById(int id)
        {
            return dbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Delete(int id)
        {
            TEntity entity = dbSet.Find(id);
            Delete(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }

        public virtual void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
