using Translator.Core.Common;

namespace Translator.Core.IServices
{
    public interface IExcelService
    {
        void Translate(string inputPath, string outputPath, TranslateType type);
    }
}
