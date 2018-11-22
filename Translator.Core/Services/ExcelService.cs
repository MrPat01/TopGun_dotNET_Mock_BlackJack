using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using Translator.Core.Common;

namespace Translator.Core.Services
{
    public class ExcelService
    {
        private string TranslateText(string text, TranslateType type)
        {
            return String.Empty;
        }

        private void Statistic(long wordCount, long pageCount)
        {
            return;
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
                    currentSheet.Name = TranslateText(currentSheet.Name, type);

                    //Translate each cell
                    for (int c = 1; c <= currentSheet.Dimension.End.Column; c++)
                    {
                        for (int r = 1; r <= currentSheet.Dimension.End.Row; r++)
                        {
                            if (currentSheet.Cells[r, c].Value != null)
                            {
                                currentSheet.Cells[r, c].Value = TranslateText(currentSheet.Cells[r, c].Value.ToString(), type);
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
