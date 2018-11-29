using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Translator.Core.Common;
using Translator.Core.IServices;
using Type = Translator.Core.Models.Type;

namespace Translator.Client
{
    public partial class Client : Form
    {
        private const string V = "All Files (*.txt, *.xlsx)|*.txt; *.xlsx";
        private readonly IExcelService _excelService;
        private readonly ITxtService _txtService;
        private readonly IDictionaryService _dictionaryService;
        private readonly ITypeService _typeService;
        public Client(IDictionaryService dictionaryService, ITypeService typeService, IExcelService excelService, ITxtService txtService)
        {
            _dictionaryService = dictionaryService;
            _typeService = typeService;
            _excelService = excelService;
            _txtService = txtService;
            InitializeComponent();

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            var type = _typeService.GetAll().ToList();
            cbb_type.DataSource = type;
            cbb_type.DisplayMember = "Name";
            cbb_type.ValueMember = "Id";
            Type first = null;
            foreach (var type1 in type)
            {
                first = type1;
                break;
            }
            if (first != null) cbb_type.SelectedValue = first.Id;
        }

        private void btn_BrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog result = new OpenFileDialog {Filter = V};
            if (result.ShowDialog() == DialogResult.OK)
            {
                txt_FilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btn_BrowseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog result = new FolderBrowserDialog();
            if (result.ShowDialog() == DialogResult.OK)
            {
                txt_FolderPath.Text = result.SelectedPath;
            }
        }

        private void btn_VN2JP_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.ReportProgress(0, "Starting");
            var text = txt_VN.Text;
            this.backgroundWorker1.ReportProgress(10, "Loading");
            var translatedText = _dictionaryService.TranslateVn2Jp(text);
            this.backgroundWorker1.ReportProgress(50, "Loading");
            txt_JP.Text = translatedText.Jp;
            this.backgroundWorker1.ReportProgress(100, "Completed");
        }



        private void btn_JP2VN_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.ReportProgress(0, "Starting");
            var text = txt_JP.Text;
            this.backgroundWorker1.ReportProgress(10, "Running");
            var translatedText = _dictionaryService.TranslateJp2Vn(text);
            this.backgroundWorker1.ReportProgress(50, "Loading");
            txt_VN.Text = translatedText.Vn;
            this.backgroundWorker1.ReportProgress(100, "Completed");
        }

        private void btn_translateFile_Click(object sender, EventArgs e)
        {
            string path = txt_FilePath.Text;
            var type = (TranslateType)cbb_type.SelectedValue;
            this.backgroundWorker1.ReportProgress(0, "Starting");
            if (!string.IsNullOrWhiteSpace(path))
            {
                this.backgroundWorker1.ReportProgress(10, "Running");
                if (path.IndexOf(".txt", StringComparison.Ordinal) != -1)
                {
                    string newPath = path.Replace(".xlsx", "_JP.xlsx");
                    _txtService.Translate(path, newPath, type);
                }
                else if (path.IndexOf(".xlsx", StringComparison.Ordinal) != -1)
                {
                    string newPath = path.Replace(".xlsx", "_JP.xlsx");
                    _excelService.Translate(path, newPath, type);
                }
                this.backgroundWorker1.ReportProgress(50, "Loading");
            }
            this.backgroundWorker1.ReportProgress(100, "Completed");
        }

        private void btn_translateFolder_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.ReportProgress(0, "Starting");
            var type = (TranslateType)cbb_type.SelectedValue;
            string path = txt_FolderPath.Text;
            var files = Directory.GetFiles(path);
            this.backgroundWorker1.ReportProgress(10, "Running");
            var excelFiles = files.Where(f => f.EndsWith(".xlsx"));
            var txtFiles = files.Where(f => f.EndsWith(".txt"));
            this.backgroundWorker1.ReportProgress(50, "Loading");
            foreach (var file in excelFiles)
            {
                string newPath = file.Replace(".xlsx", "_JP.xlsx");
                _excelService.Translate(file, newPath, type);
            }
            foreach (var file in txtFiles)
            {
                string newPath = file.Replace(".txt", "_JP.txt");
                _txtService.Translate(file, newPath, type);
            }
            this.backgroundWorker1.ReportProgress(100, "Completed");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
            }
            else if (e.Error != null)
            {
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

            string temp = (string)e.UserState;
            this.progressBar.Value = (this.progressBar.Value + e.ProgressPercentage) > 100 ? e.ProgressPercentage : this.progressBar.Value + e.ProgressPercentage;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
