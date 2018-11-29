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
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                txt_FilePath.Text = result.FileName;
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
            var text = txt_VN.Text;
            var translatedText = _dictionaryService.TranslateVn2Jp(text);
            txt_JP.Text = translatedText.Jp;
        }

        private void btn_JP2VN_Click(object sender, EventArgs e)
        {
            var text = txt_JP.Text;
            var translatedText = _dictionaryService.TranslateJp2Vn(text);
            txt_VN.Text = translatedText.Vn;
        }

        private void btn_translateFile_Click(object sender, EventArgs e)
        {
            string path = txt_FilePath.Text;
            var type = (TranslateType)cbb_type.SelectedValue;

            if (!string.IsNullOrWhiteSpace(path))
            {
                if (path.IndexOf(".txt", StringComparison.Ordinal) != -1)
                {
                    string newPath = string.Empty;
                    switch (type)
                    {
                        case TranslateType.Jp2Vn:
                            newPath = path.Replace(".txt", "_VN.txt");
                            break;
                        case TranslateType.Vn2Jp:
                            newPath = path.Replace(".txt", "_JP.txt");
                            break;

                    }
                    _txtService.Translate(path, newPath, type);
                }
                else if (path.IndexOf(".xlsx", StringComparison.Ordinal) != -1)
                {
                    string newPath = string.Empty;
                    switch (type)
                    {
                        case TranslateType.Jp2Vn:
                            newPath = path.Replace(".xlsx", "_VN.xlsx");
                            break;
                        case TranslateType.Vn2Jp:
                            newPath = path.Replace(".xlsx", "_JP.xlsx");
                            break;

                    }
                    _excelService.Translate(path, newPath, type);
                }
            }
        }

        private void btn_translateFolder_Click(object sender, EventArgs e)
        {
            var type = (TranslateType)cbb_type.SelectedValue;
            string path = txt_FolderPath.Text;
            var files = Directory.GetFiles(path);
            var excelFiles = files.Where(f => f.EndsWith(".xlsx"));
            var txtFiles = files.Where(f => f.EndsWith(".txt"));
            foreach (var file in excelFiles)
            {
                string newPath = string.Empty;
                switch (type)
                {
                    case TranslateType.Jp2Vn:
                        newPath = file.Replace(".xlsx", "_VN.xlsx");
                        break;
                    case TranslateType.Vn2Jp:
                        newPath = file.Replace(".xlsx", "_JP.xlsx");
                        break;

                }
                _excelService.Translate(file, newPath,  type);
            }
            foreach (var file in txtFiles)
            {
                string newPath = string.Empty;
                switch (type)
                {
                    case TranslateType.Jp2Vn:
                        newPath = file.Replace(".txt", "_VN.txt");
                        break;
                    case TranslateType.Vn2Jp:
                        newPath = file.Replace(".txt", "_JP.txt");
                        break;

                }
                _txtService.Translate(file, newPath, type);
            }
        }
    }
}
