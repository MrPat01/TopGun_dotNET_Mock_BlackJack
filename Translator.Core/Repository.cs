using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator.Core.IServices;
using Translator.Core;

namespace Translator.Core.Services
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly TranslatorContext _dbContext = new TranslatorContext();
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
            _dbContext.Entry<T>(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return entity;
        }

        public T Delete(int Key)
        {
            var entity = _dbContext.Set<T>().Where(x => x.Id == Key).FirstOrDefault();
            entity.DeletedAt = DateTime.Now;
            entity.IsDeleted = true;
            _dbContext.Entry<T>(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return entity;
        }

        public T GetByKey(int Id)
        {
            return _dbContext.Set<T>().Where(x => x.Id == Id).FirstOrDefault();
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
            _dbContext.Entry<T>(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return entity;
        }
    }
}
