using Translator.Core.Common;
using Translator.Core.Models;

namespace Translator.Core.IServices
{
    public interface IDictionaryService : IRepository<Dictionary>
    {
        Dictionary TranslateVn2Jp(string Input);
        Dictionary TranslateJp2Vn(string Input);
        Dictionary Translate(string Input, int type);
        string TranslateText(string text, TranslateType type);
    }
}
