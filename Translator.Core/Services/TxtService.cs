using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
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

            var SplitReadText = readText.Split('.');
            string createText = "";

            foreach (var item in SplitReadText)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    continue;
                }
                var text = item.Replace("\r", "").Replace("\n", "");
                text += ".";
                //translate here

                if (item.IndexOf("\n") > 0)
                {
                    createText += Environment.NewLine + _dictionaryService.TranslateText(text, type);
                }
                else
                {
                    createText += _dictionaryService.TranslateVN2JP(text).JP;
                }
            }

            File.WriteAllText(outputPath, createText, Encoding.UTF8);
        }
    }
}
