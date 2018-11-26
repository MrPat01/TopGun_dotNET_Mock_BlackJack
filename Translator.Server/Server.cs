using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translator.Core.Common;
using Translator.Core.IServices;

namespace Translator.Server
{

    public partial class Server : Form
    {
        private readonly IExcelService _excelService;
        private readonly ITxtService _txtService;
        private readonly Core.IServices.IConfigPathService _configPathService;
        public Server(Core.IServices.IConfigPathService ConfigPathService, IExcelService excelService, ITxtService txtService)
        {
            _configPathService = ConfigPathService;
            _excelService = excelService;
            _txtService = txtService;
            InitializeComponent();
            this.Text = "Black Jack - Server -v01.00";
        }

        private void Server_Load(object sender, EventArgs e)
        {
            var configPath = _configPathService.GetAll().ToList();
            txt_JP_Input.Text = configPath.FirstOrDefault(x => x.Name == "JP2VNInput").Path;
            txt_JP_BackUp.Text = configPath.FirstOrDefault(x => x.Name == "JP2VNBackUp").Path;
            txt_JP_Output.Text = configPath.FirstOrDefault(x => x.Name == "JP2VNOutput").Path;
            txt_JP_Error.Text = configPath.FirstOrDefault(x => x.Name == "JP2VNError").Path;
            txt_VN_Input.Text = configPath.FirstOrDefault(x => x.Name == "VN2JPInput").Path;
            txt_VN_Backup.Text = configPath.FirstOrDefault(x => x.Name == "VN2JPBackUp").Path;
            txt_VN_Output.Text = configPath.FirstOrDefault(x => x.Name == "VN2JPOutput").Path;
            txt_VN_Error.Text = configPath.FirstOrDefault(x => x.Name == "VN2JPError").Path;
        }

        private void btn_JP_Input_Click(object sender, EventArgs e)
        {
            var path = txt_JP_Input.Text;
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Process.Start(path);
        }

        private void btn_JP_BackUp_Click(object sender, EventArgs e)
        {
            var path = txt_JP_BackUp.Text;
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Process.Start(path);
        }

        private void btn_JP_Output_Click(object sender, EventArgs e)
        {
            var path = txt_JP_Output.Text;
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Process.Start(path);
        }

        private void btn_JP_Error_Click(object sender, EventArgs e)
        {
            var path = txt_JP_Error.Text;
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Process.Start(path);
        }

        private void btn_VN_Input_Click(object sender, EventArgs e)
        {
            var path = txt_VN_Input.Text;
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Process.Start(path);
        }

        private void btn_VN_Backup_Click(object sender, EventArgs e)
        {
            var path = txt_VN_Backup.Text;
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Process.Start(path);
        }

        private void btn_VN_Output_Click(object sender, EventArgs e)
        {
            var path = txt_VN_Output.Text;
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Process.Start(path);
        }

        private void btn_VN_Error_Click(object sender, EventArgs e)
        {
            var path = txt_VN_Error.Text;
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Process.Start(path);
        }
        public void AutoTranslate()
        {
            if (checkFileNew())
            {
                AutoTranslateVN2JP();
                AutoTranslateJP2VN();
            }
        }
        public bool checkFileNew()
        {
            //get folder path
            string folderVNOutPut = txt_VN_Output.Text;
            string folderVNInPut = txt_VN_Input.Text;
            string folderJPOutPut = txt_JP_Output.Text;
            string folderJPInPut = txt_JP_Input.Text;
            //get file name order by ASC
            var fileInFolderVNOutPut = Directory.EnumerateFiles(folderVNOutPut, "*.txt; *.xlsx;").OrderBy(x=>x).ToList();
            var fileInFolderVNInPut = Directory.EnumerateFiles(folderVNInPut, "*.txt; *.xlsx;").OrderBy(x => x).ToList();
            var fileInFolderJPOutPut = Directory.EnumerateFiles(folderJPOutPut, "*.txt; *.xlsx;").OrderBy(x => x).ToList();
            var fileInFolderJPInPut = Directory.EnumerateFiles(folderJPInPut, "*.txt; *.xlsx;").OrderBy(x => x).ToList();
            //check new file
            if (fileInFolderVNOutPut.Count != fileInFolderVNInPut.Count || fileInFolderJPOutPut.Count == fileInFolderJPInPut.Count)
                return true;
            if (fileInFolderVNOutPut.Count == fileInFolderVNInPut.Count)
            {
                for (int i = 0; i < fileInFolderVNOutPut.Count; i++)
                {
                    if (fileInFolderVNOutPut[i] != fileInFolderVNInPut[i].Replace(".txt", "_VN.txt"))
                    {
                        return true;
                    }
                }
            }
            if (fileInFolderJPOutPut.Count == fileInFolderJPInPut.Count)
            {
                for (int i = 0; i < fileInFolderJPOutPut.Count; i++)
                {
                    if (fileInFolderJPOutPut[i] != fileInFolderJPInPut[i].Replace(".txt", "_JP.txt"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void AutoTranslateVN2JP()
        {
            string pathInput = txt_VN_Input.Text;
            string pathOutput = txt_VN_Output.Text;
            var filesInput = Directory.GetFiles(pathInput).ToList();
            var filesInputTemp = Directory.GetFiles(pathInput).ToList();
            var filesOutput = Directory.GetFiles(pathOutput).ToList();
            //remove file has been translated
            foreach (var item in filesInput)
            {
                var file = item.EndsWith("txt") ? item.Replace(".txt", "_JP.txt") : item.EndsWith("xlsx") ? item.Replace(".xlsx", "_JP.xlsx") : item;
                if (filesOutput.Contains(file))
                {
                    filesInputTemp.Remove(item);
                }
            }
            var excelFiles = filesInputTemp.Where(f => f.EndsWith(".xlsx"));
            var txtFiles = filesInputTemp.Where(f => f.EndsWith(".txt"));
            foreach (var file in excelFiles)
            {
                string newPath = file.Replace(".xlsx", "_JP.xlsx");
                _excelService.Translate(file, newPath, TranslateType.Vn2Jp);
            }
            foreach (var file in txtFiles)
            {
                string newPath = file.Replace(".txt", "_JP.txt");
                _txtService.Translate(file, newPath, TranslateType.Vn2Jp);
            }
        }
        public void AutoTranslateJP2VN()
        {
            string pathInput = txt_JP_Input.Text;
            string pathOutput = txt_JP_Output.Text;
            var filesInput = Directory.GetFiles(pathInput).ToList();
            var filesInputTemp = Directory.GetFiles(pathInput).ToList();
            var filesOutput = Directory.GetFiles(pathOutput).ToList();
            //remove file has been translated
            foreach (var item in filesInput)
            {
                var file = item.EndsWith("txt") ? item.Replace(".txt", "_VN.txt") : item.EndsWith("xlsx") ? item.Replace(".xlsx", "_VN.xlsx") : item;
                if (filesOutput.Contains(file))
                {
                    filesInputTemp.Remove(item);
                }
            }
            var excelFiles = filesInputTemp.Where(f => f.EndsWith(".xlsx"));
            var txtFiles = filesInputTemp.Where(f => f.EndsWith(".txt"));
            foreach (var file in excelFiles)
            {
                string newPath = file.Replace(".xlsx", "_VN.xlsx");
                _excelService.Translate(file, newPath, TranslateType.Jp2Vn);
            }
            foreach (var file in txtFiles)
            {
                string newPath = file.Replace(".txt", "_VN.txt");
                _txtService.Translate(file, newPath, TranslateType.Jp2Vn);
            }
        }
    }
}
