using System.IO;
using System.Linq;
using OfficeOpenXml;
using Translator.Core.Common;
using Translator.Core.IServices;

namespace Translator.Core.Services
{
    public class ExcelService:IExcelService
    {
        private readonly IDictionaryService _dictionaryService;

        public ExcelService(IDictionaryService dictionaryService)
        {
            _dictionaryService = dictionaryService;
        }

        public void Translate(string inputPath, string outputPath, TranslateType type)
        {
            var fi = new FileInfo(inputPath);

            using (var package = new ExcelPackage(fi))
            {
                var listSheet = package.Workbook.Worksheets;
                for (int i = 1; i <= listSheet.Count(); i++)
                {
                    var currentSheet = listSheet[i];

                    //Translate sheet name
                    currentSheet.Name = _dictionaryService.TranslateText(currentSheet.Name, type);

                    //Translate each cell
                    for (int c = 1; c <= currentSheet.Dimension.End.Column; c++)
                    {
                        for (int r = 1; r <= currentSheet.Dimension.End.Row; r++)
                        {
                            if (currentSheet.Cells[r, c].Value != null)
                            {
                                currentSheet.Cells[r, c].Value = _dictionaryService.TranslateText(currentSheet.Cells[r, c].Value.ToString(), type);
                            }
                        }
                    }
                }

                var outputFile = new FileInfo(outputPath);
                package.SaveAs(outputFile);
            }
        }
    }
}
