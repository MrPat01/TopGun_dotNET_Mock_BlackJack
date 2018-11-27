using System;
using System.Collections.Generic;
using System.ComponentModel;
using Translator.Core.IServices;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translator.Core.IServices;

namespace Translator.Admin
{
    public partial class MainForm : Form
    {
        private readonly IDictionaryService _dictionaryService;
        private readonly IFieldService _fieldService;
        public static Core.Models.Dictionary dictionary = new Core.Models.Dictionary();
        public MainForm(IDictionaryService dictionaryService, IFieldService fieldService)
        {
            _dictionaryService = dictionaryService;
            _fieldService = fieldService;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GridData.DataSource = _dictionaryService.GetAll().Select(x => new
            {
                x.Id,
                x.VN,
                x.VNLength,
                x.JP,
                x.JPLength,
                x.TypeId,
                x.DictionaryTypeId,
                x.Date,
            }).ToList();
            GridData.MultiSelect = true;
            GridData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_delete_data_Click(object sender, EventArgs e)
        {
            var confirmDelete = MessageBox.Show("Do you want to delete?", "Confirm delete!!!", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                var cellSelected = GridData.SelectedRows;
                var count = cellSelected.Count;
                for (int i = 0; i < count; i++)
                {
                    var id = (int)cellSelected[i].Cells[1].Value;
                    _dictionaryService.Delete(id);
                }
                MessageBox.Show("Delete success!!!");
                GridData.DataSource = _dictionaryService.GetAll().Select(x => new
                {
                    x.Id,
                    x.VN,
                    x.VNLength,
                    x.JP,
                    x.JPLength,
                    x.TypeId,
                    x.DictionaryTypeId,
                    x.Date,
                }).ToList();
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

        private void btn_add_new_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(_dictionaryService, new Core.Models.Dictionary());
            editForm.Show();
        }

        private void GridData_DoubleClick(object sender, EventArgs e)
        {
            var cell = GridData.CurrentCell.Value;
            dictionary = _dictionaryService.GetByKey((int)cell);
            EditForm editForm = new EditForm(_dictionaryService, dictionary);
            editForm.Show();
        }
    }
}
