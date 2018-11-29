using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Translator.Core.Common;
using Translator.Core.IServices;

namespace Translator.Server
{

    public partial class Server : Form
    {
        private const string StopString = "Stop";
        private const string RunString = "Run";
        private readonly IExcelService _excelService;
        private readonly ITxtService _txtService;
        private readonly IConfigPathService _configPathService;
        readonly Timer _myTimer = new Timer();
        public Server(IConfigPathService configPathService, IExcelService excelService, ITxtService txtService)
        {
            _configPathService = configPathService;
            _excelService = excelService;
            _txtService = txtService;
            InitializeComponent();
            //Text = "Black Jack - Server -v01.00";
        }

        private void Server_Load(object sender, EventArgs e)
        {
            var configPath = _configPathService.GetAll().ToList();
            txt_JP_Input.Text = configPath.FirstOrDefault(x => x.Name == "JP2VNInput")?.Path;
            txt_JP_BackUp.Text = configPath.FirstOrDefault(x => x.Name == "JP2VNBackUp")?.Path;
            txt_JP_Output.Text = configPath.FirstOrDefault(x => x.Name == "JP2VNOutput")?.Path;
            txt_JP_Error.Text = configPath.FirstOrDefault(x => x.Name == "JP2VNError")?.Path;
            txt_VN_Input.Text = configPath.FirstOrDefault(x => x.Name == "VN2JPInput")?.Path;
            txt_VN_Backup.Text = configPath.FirstOrDefault(x => x.Name == "VN2JPBackUp")?.Path;
            txt_VN_Output.Text = configPath.FirstOrDefault(x => x.Name == "VN2JPOutput")?.Path;
            txt_VN_Error.Text = configPath.FirstOrDefault(x => x.Name == "VN2JPError")?.Path;
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
            if (CheckFileNew())
            {
                AutoTranslateVn2Jp();
                AutoTranslateJp2Vn();
            }
        }
        public bool CheckFileNew()
        {
            //get folder path
            string folderVnOutPut = txt_VN_Output.Text;
            string folderVnInPut = txt_VN_Input.Text;
            string folderJpOutPut = txt_JP_Output.Text;
            string folderJpInPut = txt_JP_Input.Text;
            //check folder exist
            if (!File.Exists(folderVnOutPut))
            {
                Directory.CreateDirectory(folderVnOutPut);
            }
            if (!File.Exists(folderVnInPut))
            {
                Directory.CreateDirectory(folderVnInPut);
            }
            if (!File.Exists(folderJpOutPut))
            {
                Directory.CreateDirectory(folderJpOutPut);
            }
            if (!File.Exists(folderJpInPut))
            {
                Directory.CreateDirectory(folderJpInPut);
            }
            //get file name order by ASC
            var fileInFolderVnOutPut = Directory.EnumerateFiles(folderVnOutPut, "*.txt; *.xlsx;").OrderBy(x => x).ToList();
            var fileInFolderVnInPut = Directory.EnumerateFiles(folderVnInPut, "*.txt; *.xlsx;").OrderBy(x => x).ToList();
            var fileInFolderJpOutPut = Directory.EnumerateFiles(folderJpOutPut, "*.txt; *.xlsx;").OrderBy(x => x).ToList();
            var fileInFolderJpInPut = Directory.EnumerateFiles(folderJpInPut, "*.txt; *.xlsx;").OrderBy(x => x).ToList();
            //check new file
            if (fileInFolderVnOutPut.Count != fileInFolderVnInPut.Count || fileInFolderJpOutPut.Count == fileInFolderJpInPut.Count)
                return true;
            if (fileInFolderVnOutPut.Count == fileInFolderVnInPut.Count)
            {
                for (int i = 0; i < fileInFolderVnOutPut.Count; i++)
                {
                    if (fileInFolderVnOutPut[i] != fileInFolderVnInPut[i].Replace(".txt", "_VN.txt"))
                    {
                        return true;
                    }
                }
            }
            if (fileInFolderJpOutPut.Count == fileInFolderJpInPut.Count)
            {
                for (int i = 0; i < fileInFolderJpOutPut.Count; i++)
                {
                    if (fileInFolderJpOutPut[i] != fileInFolderJpInPut[i].Replace(".txt", "_JP.txt"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void AutoTranslateVn2Jp()
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
                _excelService.Translate(file, newPath.Replace("Input", "Output"), TranslateType.Vn2Jp);
            }
            foreach (var file in txtFiles)
            {
                string newPath = file.Replace(".txt", "_JP.txt");
                _txtService.Translate(file, newPath.Replace("Input", "Output"), TranslateType.Vn2Jp);
            }
        }
        public void AutoTranslateJp2Vn()
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
                _excelService.Translate(file, newPath.Replace("Input", "Output"), TranslateType.Jp2Vn);
            }
            foreach (var file in txtFiles)
            {
                string newPath = file.Replace(".txt", "_VN.txt");
                _txtService.Translate(file, newPath.Replace("Input", "Output"), TranslateType.Jp2Vn);
            }
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            var text = btn_Run.Text;
            if (text == "Run")
            {
                btn_Run.Text = StopString;
                AutoTranslate();
                _myTimer.Interval = Constants.RefreshTime;
                _myTimer.Tick += MyTimer_Tick;
                _myTimer.Start();
            }
            else
            {
                btn_Run.Text = RunString;
                _myTimer.Stop();
            }
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            AutoTranslate();
        }
    }
}
