using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translator.Core.IServices;
using Translator.Core.Models;

namespace Translator.Admin
{
    public partial class EditForm : Form
    {
        private readonly IDictionaryService _dictionaryService;

        public EditForm(IDictionaryService dictionaryService)
        {
            _dictionaryService = dictionaryService;
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Dictionary dictionary = new Dictionary();
            
            dictionary.JP = txt_jp.Text;
            dictionary.VN = txt_vn.Text;
            dictionary.CategoryId = int.Parse(cbb_category.SelectedValue.ToString());
            dictionary.Priority = short.Parse(txt_priority.Text);
            dictionary.Inputer = txt_inputer.Text;
            dictionary.TypeId = short.Parse(cbb_data_type.SelectedValue.ToString());
            dictionary.DictionaryTypeId = short.Parse(cbb_translate_type.SelectedValue.ToString());

            _dictionaryService.AddNew(dictionary);
        }
    }
}
