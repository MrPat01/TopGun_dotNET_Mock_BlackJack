using System;
using System.IO;
using System.Text;
using Translator.Core.Common;
using Translator.Core.IServices;

namespace Translator.Core.Services
{
    public class TxtService : ITxtService
    {
        private readonly IDictionaryService _dictionaryService;

        public TxtService(IDictionaryService dictionaryService)
        {
            _dictionaryService = dictionaryService;
        }

        public void Translate(string inputPath, string outputPath, TranslateType type)
        {
            string readText = File.ReadAllText(inputPath);

            var splitReadText = readText.Split('.');
            string createText = "";

            foreach (var item in splitReadText)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    continue;
                }
                var text = item.Replace("\r", "").Replace("\n", "");
                //text += ".";
                //translate here

                if (item.IndexOf("\n", StringComparison.Ordinal) > 0)
                {
                    createText += Environment.NewLine + _dictionaryService.TranslateText(text, type);
                }
                else
                {
                    createText += _dictionaryService.TranslateText(text, type);
                }
            }

            File.WriteAllText(outputPath, createText, Encoding.UTF8);
        }
    }
}
