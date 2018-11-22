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

namespace Translator.Client
{
    public partial class Client : Form
    {
        private readonly Core.IServices.IDictionaryService _dictionaryService;
        private readonly Core.IServices.ITypeService _TypeService;
        public Client()
        {
            //_dictionaryService = dictionaryService;
            //_TypeService = TypeService;
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
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                txt_FilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btn_BrowseFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txt_FolderPath.Text = openFileDialog1.FileName;
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
    }
}
