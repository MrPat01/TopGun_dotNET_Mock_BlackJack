using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator.Core.Filter;
using Translator.Core.Models;

namespace Translator.Core.Services
{
    public class DictionaryService : Repository<Dictionary>, Translator.Core.IServices.IDictionaryService
    {
        public DictionaryService(DbContext dbContext) : base(dbContext)
        {
        }
        public Dictionary Muti_Condition(List<DictionaryFilter> Search)
        {
            var query = GetAll().FirstOrDefault();
            return query;
        }
    }
}
