using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Gymcim.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : class, new()
    where TContext : DbContext, new()
    {
        public void Add(TEntity ent)
        {
            using (TContext context = new TContext())
            {
                var entity = context.Entry(ent);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity ent)
        {
            using (TContext context = new TContext())
            {
                var entity = context.Entry(ent);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter != null ? context.Set<TEntity>().Where(filter).ToList()
                    : context.Set<TEntity>().ToList();
            }
        }

        public void Update(TEntity ent)
        {
            using (TContext context = new TContext())
            {
                var entity = context.Entry(ent);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
