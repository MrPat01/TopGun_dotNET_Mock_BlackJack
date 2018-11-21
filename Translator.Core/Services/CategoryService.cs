using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator.Core.IServices;
using Translator.Core.Models;

namespace Translator.Core.Services
{
    public class CategoryService : Repository<Category>, ICategoryService
    {
        public CategoryService(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
