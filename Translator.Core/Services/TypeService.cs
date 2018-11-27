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
