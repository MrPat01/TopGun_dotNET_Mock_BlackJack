using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Translator.Core.Common;
using Translator.Core.IServices;
using Translator.Core.Models;
using DynamicExpression = System.Linq.Dynamic.DynamicExpression;

namespace Translator.Admin
{
    public partial class SearchBox : UserControl
    {
        private IFieldService _fieldService;

        public bool EnableAndOrCombobox
        {
            get => cbAndOr.Visible;
            set => cbAndOr.Visible = value;
        }

        public SearchBox()
        {
            InitializeComponent();
            _fieldService = Program.container.GetInstance<IFieldService>();
            SetComboBoxData();
        }

        private void SetComboBoxData()
        {
            var type = _fieldService.GetAll().ToList();
            type.Insert(0, new Field());
            cbProperty.DataSource = type;
            cbProperty.DisplayMember = "Name";
            cbProperty.ValueMember = "Id";
            //cbProperty.SelectedItem = null;

            var operations = Constants.Operations;
            cbOperation.DataSource = Constants.Operations;
            //cbOperation.SelectedItem = null;

            var andOr = Constants.AndOr;
            cbAndOr.DataSource = Constants.Operations;
            //cbOperation.SelectedItem = null;
        }

        private void cbProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = cbProperty.SelectedIndex;
            if (selectedIndex == 0)
            {
                tbSearchValue.Enabled = cbOperation.Enabled = false;
            }
            else
            {
                cbOperation.Enabled = true;
                tbSearchValue.Enabled = cbOperation.SelectedIndex > 0;
            }
        }

        private void cbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = cbOperation.SelectedIndex;
            tbSearchValue.Enabled = selectedIndex > 0;
        }

        public string GetAndOr()
        {
            if (EnableAndOrCombobox && cbAndOr.SelectedIndex > 0)
            {
                return " " + ((string) cbAndOr.SelectedItem).ToLower() + " ";
            }
            else
            {
                return string.Empty;
            }
        }

        public Expression<Func<Dictionary, bool>> GetExpression()
        {
            if (cbProperty.SelectedIndex > 0 && cbOperation.SelectedIndex > 0 &&
                !string.IsNullOrWhiteSpace(tbSearchValue.Text) && (!EnableAndOrCombobox || cbAndOr.SelectedIndex > 0))
            {
                var property = (Field) cbProperty.SelectedItem;
                var operation = (string) cbOperation.SelectedItem;
                var value = tbSearchValue.Text;
                switch (operation)
                {
                    case "Equal": return DynamicExpression.ParseLambda<Dictionary, bool>(property.Name + " = @0", value);
                    case "Contain": return DynamicExpression.ParseLambda<Dictionary, bool>(property.Name + ".Contains(@0)", value);
                    default:return null;
                }
            }
            else
            {
                return null;
            }
        }

        private void cbAndOr_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = cbAndOr.SelectedIndex;
            if(selectedIndex == 0)
            {
                tbSearchValue.Enabled = cbProperty.Enabled = cbOperation.Enabled = false;
            }
            else
            {
                cbProperty.Enabled = true;
                cbOperation.Enabled = cbProperty.SelectedIndex > 0;
                tbSearchValue.Enabled = cbOperation.SelectedIndex > 0;
            }
        }
    }
}
