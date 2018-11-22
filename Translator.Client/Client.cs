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

namespace Translator.Client
{
    public partial class Client : Form
    {
        private readonly Core.IServices.IDictionaryService _dictionaryService;
        private readonly Core.IServices.ITypeService _typeService;
        public Client(Core.IServices.IDictionaryService dictionaryService, Core.IServices.ITypeService typeService)
        {
            _dictionaryService = dictionaryService;
            _typeService = typeService;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Client_Load(object sender, EventArgs e)
        {
        }

        private void btn_BrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog result = new OpenFileDialog();
            result.Filter = "All Files (*.txt, *.xlsx, *.xls)|*.txt; *.xlsx; *.xls";
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
            int type = (int)cbb_type.SelectedValue;
            if (!string.IsNullOrWhiteSpace(path))
            {
                if (path.IndexOf(".txt") != -1)
                {
                    translateTxt(path, type);
                }
                else if (path.IndexOf(".xlsx") != -1)
                {
                    string newPath = path.Replace(".xlsx", "_JP.xlsx");
                }
                else
                {
                    string newPath = path.Replace(".xls", "_JP.xls");
                }
            }
        }

        public void translateTxt(string filePath, int type)
        {
            if (type == (int)TranslateType.Vn2Jp)
            {
                string newPath = filePath.Replace(".txt", "_JP.txt");
                string readText = File.ReadAllText(filePath);

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
                        createText += Environment.NewLine + _dictionaryService.TranslateVN2JP(text).JP;
                    }
                    else
                    {
                        createText += _dictionaryService.TranslateVN2JP(text).JP;
                    }
                }

                File.WriteAllText(newPath, createText, Encoding.UTF8);
            }
            else
            {
                string newPath = filePath.Replace(".txt", "_VN.txt");
                string readText = File.ReadAllText(filePath);

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
                        createText += Environment.NewLine + _dictionaryService.TranslateVN2JP(text).VN;
                    }
                    else
                    {
                        createText += _dictionaryService.TranslateVN2JP(text).VN;
                    }
                }

                File.WriteAllText(newPath, createText, Encoding.UTF8);
            }
        }
    }
}
