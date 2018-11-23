using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translator.Core.Common;
using Translator.Core.IServices;

namespace Translator.Client
{
    public partial class Client : Form
    {
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
            cbb_type.SelectedValue = type.FirstOrDefault().Id;
        }

        private void btn_BrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog result = new OpenFileDialog();
            result.Filter = "All Files (*.txt, *.xlsx)|*.txt; *.xlsx";
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
            var text = txt_VN.Text;
            var TranslatedText = _dictionaryService.TranslateVN2JP(text);
            txt_JP.Text = TranslatedText.JP;
        }

        private void btn_JP2VN_Click(object sender, EventArgs e)
        {
            var text = txt_JP.Text;
            var TranslatedText = _dictionaryService.TranslateJP2VN(text);
            txt_VN.Text = TranslatedText.VN;
        }

        private void btn_translateFile_Click(object sender, EventArgs e)
        {
            string path = txt_FilePath.Text;
            var type = (TranslateType)cbb_type.SelectedValue;

            if (!string.IsNullOrWhiteSpace(path))
            {
                if (path.IndexOf(".txt") != -1)
                {
                    string newPath = path.Replace(".xlsx", "_JP.xlsx");
                    _txtService.Translate(path, newPath, type);
                }
                else if (path.IndexOf(".xlsx") != -1)
                {
                    string newPath = path.Replace(".xlsx", "_JP.xlsx");
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
                string newPath = file.Replace(".xlsx", "_JP.xlsx");
                _excelService.Translate(file, newPath,  type);
            }
            foreach (var file in txtFiles)
            {
                string newPath = file.Replace(".txt", "_JP.txt");
                _txtService.Translate(file, newPath, type);
            }
        }

        //private void btn_translateFolder_Click(object sender, EventArgs e)
        //{
        //    string folderPath = txt_FolderPath.Text;
        //    foreach (string path in Directory.EnumerateFiles(folderPath, "*.txt; *.xlsx; *.xls"))
        //    {
        //        int type = (int)cbb_type.SelectedValue;
        //        if (!string.IsNullOrWhiteSpace(path))
        //        {
        //            if (path.IndexOf(".txt") != -1)
        //            {
        //                translateTxt(path, type);
        //            }
        //            else if (path.IndexOf(".xlsx") != -1)
        //            {
        //                string newPath = path.Replace(".xlsx", "_JP.xlsx");
        //            }
        //            else
        //            {
        //                string newPath = path.Replace(".xls", "_JP.xls");
        //            }
        //        }
        //    }
        //}
    }
}
