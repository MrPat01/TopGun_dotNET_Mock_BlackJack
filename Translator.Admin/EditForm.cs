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
        private readonly Dictionary _dictionary;
        public EditForm(IDictionaryService dictionaryService, Dictionary dictionary)
        {
            _dictionary = dictionary;
            _dictionaryService = dictionaryService;
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Core.Models.Dictionary dictionary = new Core.Models.Dictionary();
            
            dictionary.JP = txt_jp.Text;
            dictionary.VN = txt_vn.Text;
            dictionary.CategoryId = int.Parse(cbb_category.SelectedValue.ToString());
            dictionary.Priority = short.Parse(txt_priority.Text);
            dictionary.Inputer = txt_inputer.Text;
            dictionary.TypeId = short.Parse(cbb_data_type.SelectedValue.ToString());
            dictionary.DictionaryTypeId = short.Parse(cbb_translate_type.SelectedValue.ToString());
            if(txt_id.Text != null)
            {
                int? id = int.Parse(txt_id.Text);
                dictionary.Id = int.Parse(txt_id.Text);
                _dictionaryService.Update(dictionary);
            }
            else
            {
                _dictionaryService.AddNew(dictionary);
            }            
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            txt_jp.Text = _dictionary.JP;
            txt_vn.Text = _dictionary.VN;
            cbb_category.SelectedValue = _dictionary.CategoryId;
            txt_priority.Text = _dictionary.Priority.ToString();
            txt_inputer.Text = _dictionary.Inputer;
            cbb_data_type.SelectedValue = _dictionary.TypeId;
            cbb_translate_type.SelectedValue = _dictionary.DictionaryTypeId;
        }
    }
}
