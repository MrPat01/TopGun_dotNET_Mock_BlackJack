using Translator.Core.IServices;
using Translator.Core.Models;

namespace Translator.Core.Services
{
    public class CategoryService : Repository<Category>, ICategoryService
    {
        public CategoryService(TranslatorContext dbContext) : base(dbContext)
        {
        }
    }
}
