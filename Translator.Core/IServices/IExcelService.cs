using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator.Core.Common;

namespace Translator.Core.IServices
{
    public interface IExcelService
    {
        void Translate(string inputPath, string outputPath, TranslateType type);
    }
}
