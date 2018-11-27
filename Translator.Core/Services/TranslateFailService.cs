using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator.Core.IServices;
using Translator.Core.Models;

namespace Translator.Core.Services
{
    public class TranslateFailService : Repository<TranslateFail>, ITranslateFailService
    {
        public TranslateFailService(TranslatorContext dbContext) : base(dbContext)
        {
        }
    }
}
