using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Entity;
using Domain.Abstract;

namespace Domain.Concrete
{
    public class EFRepository<TEntity>:IRepository<TEntity> where TEntity:class 
    {
        private ApplicationDbContext context;
        private DbSet<TEntity> dbSet;

        public EFRepository(ApplicationDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }
        public IQueryable<TEntity> GetRepository()
        {
            return dbSet;
        }
        public void InsertEntity(TEntity entity)
        {
            dbSet.Add(entity);
        }
        public void DeleteEntity(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }
        public void UpdateEntity(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
        
    }
}
