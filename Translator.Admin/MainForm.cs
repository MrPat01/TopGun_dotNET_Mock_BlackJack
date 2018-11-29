using System;
using System.Collections.Generic;
using Translator.Core.IServices;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Windows.Forms;
using Translator.Core.Models;

namespace Translator.Admin
{
    public partial class MainForm : Form
    {
        private const string DeleteMessage = "Confirm delete!!!";
        private static string _confirmMessage = "Do you want to delete?";
        private const string Success = "Delete success!!!";
        private readonly ICategoryService _categoryService;
        private readonly ITypeService _typeService;
        public static Dictionary _dictionary = new Dictionary();
        private readonly IDictionaryService _dictionaryService;
        private readonly List<SearchBox> _listSearchBox;

        public MainForm(ICategoryService categoryService, ITypeService typeService, IDictionaryService dictionaryService)
        {
            _categoryService = categoryService;
            _typeService = typeService;
            _dictionaryService = dictionaryService;
            InitializeComponent();
            _listSearchBox = new List<SearchBox>
            {
                searchBox1,
                searchBox2,
                searchBox3,
                searchBox4,
                searchBox5,
                searchBox6,
                searchBox7,
                searchBox8,
                searchBox9,
                searchBox10,
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GridData.DataSource = _dictionaryService.GetAll().Select(x => new
            {
                x.Id,
                VN = x.Vn,
                VNLength = x.VnLength,
                JP = x.Jp,
                JPLength = x.JpLength,
                x.TypeId,
                x.DictionaryTypeId,
                x.Date,
            }).ToList();
            GridData.MultiSelect = true;
            GridData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_delete_data_Click(object sender, EventArgs e)
        {
            var confirmDelete = MessageBox.Show(_confirmMessage, DeleteMessage, MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                var cellSelected = GridData.SelectedRows;
                var count = cellSelected.Count;
                for (int i = 0; i < count; i++)
                {
                    var id = (int) cellSelected[i].Cells[1].Value;
                    _dictionaryService.Delete(id);
                }

                MessageBox.Show(Success);
                RefreshData();
            }
        }

        private void GridData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in GridData.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.Equals(true)) //0 is the column number of checkbox
                {
                    row.Selected = true;
                    row.DefaultCellStyle.SelectionBackColor = Color.Blue;
                }
                else
                    row.Selected = false;
            }
        }

        public void RefreshData()
        {
            btn_search_Click(null, null);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var predicate = string.Empty;
            var parameterList = new List<Expression<Func<Dictionary, bool>>>();
            int parameterIndex = 0;

            foreach (var searchBox in _listSearchBox)
            {
                var expression = searchBox.GetExpression();
                var andOr = searchBox.GetAndOr();
                if (expression != null)
                {
                    predicate += andOr + $"@{parameterIndex}(it)";
                    parameterList.Add(expression);
                    parameterIndex++;
                }
            }

            if (!string.IsNullOrWhiteSpace(predicate) && parameterList.Any())
            {
                var parameterArray = parameterList.ToArray<object>();
                IEnumerable<Dictionary> query = _dictionaryService.GetAll().ToList().Where(predicate, parameterArray);
                GridData.DataSource = query.Select(x => new
                {
                    x.Id,
                    x.Vn,
                    x.VnLength,
                    x.Jp,
                    x.JpLength,
                    x.TypeId,
                    x.DictionaryTypeId,
                    x.Date,
                }).ToList();
            }
            else
            {
                GridData.DataSource = _dictionaryService.GetAll().Select(x => new
                {
                    x.Id,
                    VN = x.Vn,
                    VNLength = x.VnLength,
                    JP = x.Jp,
                    JPLength = x.JpLength,
                    x.TypeId,
                    x.DictionaryTypeId,
                    x.Date,
                }).ToList();
            }
            
        }
        private void btn_add_new_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(_categoryService, _typeService, _dictionaryService, new Dictionary(), this);
            editForm.Show();
        }

        private void GridData_DoubleClick(object sender, EventArgs e)
        {
            var rowIndex = GridData.CurrentRow.Index;
            var Id = GridData.Rows[rowIndex].Cells[1].Value;
            _dictionary = _dictionaryService.GetByKey((int)Id);
            EditForm editForm = new EditForm(_categoryService, _typeService, _dictionaryService, _dictionary, this);
            editForm.Show();
        }
    }
}
