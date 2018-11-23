using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator.Core.Common;
using Translator.Core.Models;

namespace Translator.Core.IServices
{
    public interface IDictionaryService : IRepository<Dictionary>
    {
        Dictionary TranslateVN2JP(string Input);
        Dictionary TranslateJP2VN(string Input);
        Dictionary Translate(string Input, int type);
        string TranslateText(string text, TranslateType type)
    }
}
