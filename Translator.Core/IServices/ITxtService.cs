using Translator.Core.Common;

namespace Translator.Core.IServices
{
    public interface ITxtService
    {
        void Translate(string inputPath, string outputPath, TranslateType type);
    }
}
