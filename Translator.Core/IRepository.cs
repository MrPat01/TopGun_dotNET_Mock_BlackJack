using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator.Core;

namespace Translator.Core.IServices
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbContext GetDbContext();
        IQueryable<T> GetAll();
        T GetByKey(int Id);
        T AddNew(T entity);
        T Update(T entity);
        T Delete(T entity);
        T Delete(int Key);
    }
}
