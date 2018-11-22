using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator.Core.IServices;

namespace Translator.Core.Services
{
    public class TypeService : Repository<Models.Type>, ITypeService
    {
        public TypeService(TranslatorContext dbContext) : base(dbContext)
        {
        }
    }
}
