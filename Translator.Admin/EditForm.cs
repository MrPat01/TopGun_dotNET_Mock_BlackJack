using System;
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
            Dictionary dictionary = new Dictionary
            {
                JP = txt_jp.Text,
                VN = txt_vn.Text,
                CategoryId = int.Parse(cbb_category.SelectedValue.ToString()),
                Priority = short.Parse(txt_priority.Text),
                Inputer = txt_inputer.Text,
                TypeId = short.Parse(cbb_data_type.SelectedValue.ToString()),
                DictionaryTypeId = short.Parse(cbb_translate_type.SelectedValue.ToString())
            };
            if (txt_id.Text != null)
            {
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
