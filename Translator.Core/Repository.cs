using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Translator.Core
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly TranslatorContext _dbContext;
        public Repository(TranslatorContext dbContext)
        {
            _dbContext = dbContext;
        }
        public T AddNew(T entity)
        {
            entity.InsertedAt = DateTime.Now;
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public T Delete(T entity)
        {
            entity.DeletedAt = DateTime.Now;
            entity.IsDeleted = true;
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return entity;
        }

        public T Delete(int key)
        {
            var entity = _dbContext.Set<T>().FirstOrDefault(x => x.Id == key);
            if (entity != null)
            {
                entity.DeletedAt = DateTime.Now;
                entity.IsDeleted = true;
                _dbContext.Entry(entity).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            return entity;
        }

        public T GetByKey(int id)
        {
            return _dbContext.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public DbContext GetDbContext()
        {
            return _dbContext;
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>().Where(x=> !x.IsDeleted);
        }

        public T Update(T entity)
        {
            entity.UpdatedAt = DateTime.Now;
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return entity;
        }
        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbContext.Set<T>();
            return includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }
    }
}
