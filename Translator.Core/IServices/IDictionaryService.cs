using Translator.Core.Common;
using Translator.Core.Models;

namespace Translator.Core.IServices
{
    public interface IDictionaryService : IRepository<Dictionary>
    {
        Dictionary TranslateVn2Jp(string input);
        Dictionary TranslateJp2Vn(string input);
        Dictionary Translate(string input, int type);
        string TranslateText(string text, TranslateType type);
    }
}
