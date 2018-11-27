using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Translator.Core
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbContext GetDbContext();
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(params Expression<Func<T, object>>[] includeProperties);
        T GetByKey(int id);
        T AddNew(T entity);
        T Update(T entity);
        T Delete(T entity);
        T Delete(int key);
    }
}
