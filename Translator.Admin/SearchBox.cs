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
        public bool EnableAndOrCombobox
        {
            get => cbAndOr.Visible;
            set => cbAndOr.Visible = value;
        }

        public SearchBox()
        {
            InitializeComponent();
            SetComboBoxData();
        }

        private void SetComboBoxData()
        {
            var fieldService = Program.Container.GetInstance<IFieldService>();
            var type = fieldService.GetAll().ToList();
            type.Insert(0, new Field());
            cbProperty.DataSource = type;
            cbProperty.DisplayMember = "Name";
            cbProperty.ValueMember = "Id";
            
            cbAndOr.DataSource = Constants.AndOr;
        }

        private void cbProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = cbProperty.SelectedIndex;
            if (selectedIndex == 0)
            {
                cbOperation.DataSource = null;
                tbSearchValue.Enabled = cbOperation.Enabled = false;
            }
            else
            {
                var selectedValue = (Field) cbProperty.SelectedItem;
                cbOperation.DataSource = Constants.Operations[selectedValue.Type];
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
                return " " + ((string)cbAndOr.SelectedItem).ToLower() + " ";
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
                var property = (Field)cbProperty.SelectedItem;
                var operation = (string)cbOperation.SelectedItem;
                object value = null;
                switch (property.Type)
                {
                    case EnumType.String:
                        value = tbSearchValue.Text;
                        break;
                    case EnumType.Int:
                        value = int.Parse(tbSearchValue.Text);
                        break;
                    case EnumType.Date:
                        value = DateTime.Parse(tbSearchValue.Text);
                        break;
                }
                switch (operation)
                {
                    case "Contain": return DynamicExpression.ParseLambda<Dictionary, bool>(property.Name + ".Contains(@0)", value);
                    default: return DynamicExpression.ParseLambda<Dictionary, bool>(property.Name + " " + operation + " @0", value);
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
            if (selectedIndex == 0)
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

        private void SearchBox_Load(object sender, EventArgs e)
        {
            cbProperty.Enabled = !EnableAndOrCombobox;
        }
    }
}
