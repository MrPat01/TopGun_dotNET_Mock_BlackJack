using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Translator.Core.IServices;
using Translator.Core.Models;

namespace Translator.Admin
{
    public partial class EditForm : Form
    {
        private readonly IDictionaryService _dictionaryService;
        private readonly ICategoryService _categoryService;
        private readonly ITypeService _typeService;
        private readonly Dictionary _dictionary;
        public EditForm(ICategoryService categoryService, ITypeService typeService, IDictionaryService dictionaryService, Dictionary dictionary)
        {
            _categoryService = categoryService;
            _typeService = typeService;
            _dictionary = dictionary;
            _dictionaryService = dictionaryService;
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_id.Text) || txt_id.Text != "0")
            {
                //dictionary.Id = int.Parse(txt_id.Text);
                _dictionary.Jp = txt_jp.Text;
                _dictionary.Vn = txt_vn.Text;
                _dictionary.CategoryId = int.Parse(cbb_category.SelectedValue.ToString());
                _dictionary.Priority = short.Parse(txt_priority.Text);
                _dictionary.Inputer = txt_inputer.Text;
                _dictionary.TypeId = short.Parse(cbb_translate_type.SelectedValue.ToString());
                _dictionary.DictionaryTypeId = short.Parse(cbb_data_type.SelectedValue.ToString());
                _dictionary.Date = DateTime.Today;
                _dictionaryService.Update(_dictionary);
            }
            else
            {
                Dictionary dictionary = new Dictionary
                {
                    Jp = txt_jp.Text,
                    Vn = txt_vn.Text,
                    CategoryId = int.Parse(cbb_category.SelectedValue.ToString()),
                    Priority = short.Parse(txt_priority.Text),
                    Inputer = txt_inputer.Text,
                    TypeId = short.Parse(cbb_translate_type.SelectedValue.ToString()),
                    DictionaryTypeId = short.Parse(cbb_data_type.SelectedValue.ToString()),
                    Date = DateTime.Today
                };
                _dictionaryService.AddNew(dictionary);
            }
            this.Close();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            var type = _typeService.GetAll().ToList();
            cbb_translate_type.DataSource = type;
            cbb_translate_type.DisplayMember = "Name";
            cbb_translate_type.ValueMember = "Id";

            var category = _categoryService.GetAll().ToList();
            cbb_category.DataSource = category;
            cbb_category.DisplayMember = "Name";
            cbb_category.ValueMember = "Id";

            var dataType = new List<object>()
            {
                new
                {
                    Id = 0,
                    Name = "Type1"
                },
                new
                {
                    Id = 1,
                    Name = "Type2"
                }
            };
            cbb_data_type.DataSource = dataType;
            cbb_data_type.DisplayMember = "Name";
            cbb_data_type.ValueMember = "Id";

            txt_id.Text = _dictionary.Id.ToString();
            txt_jp.Text = _dictionary.Jp;
            txt_vn.Text = _dictionary.Vn;
            cbb_category.SelectedValue = _dictionary.CategoryId;
            txt_priority.Text = _dictionary.Priority.ToString();
            txt_inputer.Text = _dictionary.Inputer ?? String.Empty;
            cbb_data_type.SelectedValue = (int) _dictionary.DictionaryTypeId;
            cbb_translate_type.SelectedValue = (int) _dictionary.TypeId;
        }
    }
}
