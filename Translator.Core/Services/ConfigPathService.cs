using Translator.Core.IServices;
using Translator.Core.Models;

namespace Translator.Core.Services
{
    public class ConfigPathService : Repository<ConfigPath>,IConfigPathService
    {
        public ConfigPathService(TranslatorContext dbContext) : base(dbContext)
        {
        }
    }
}
