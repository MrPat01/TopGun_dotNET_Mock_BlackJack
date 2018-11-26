using System;
using System.Linq;
using System.Linq.Expressions;
using System.Linq.Dynamic;
using System.Text;
using System.Threading.Tasks;
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
        public SearchBox(IFieldService fieldService)
        {
            _fieldService = fieldService;
            InitializeComponent();
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
            operations.Insert(0, String.Empty);
            cbOperation.DataSource = Constants.Operations;
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

        public Expression<Func<Dictionary, bool>> GetExpression()
        {
            if (cbProperty.SelectedIndex > 0 && cbOperation.SelectedIndex > 0 &&
                !string.IsNullOrWhiteSpace(tbSearchValue.Text))
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
    }
}
