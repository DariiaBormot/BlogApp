using BlogDAL.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BlogDAL.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public readonly DbContext context;
        public readonly DbSet<TEntity> dbSet;

        public GenericRepository()
        {
            context = new PostContext();
            dbSet = context.Set<TEntity>();
        }

        public void Create(TEntity item)
        {
            dbSet.Add(item);
            context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {

            return dbSet.AsNoTracking().ToList();
        }

        public void Delete(int id)
        {
            var entityToDelete = dbSet.Find(id);
            dbSet.Remove(entityToDelete);
            context.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public void Update(TEntity item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }

    }
}
