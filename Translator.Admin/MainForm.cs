using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translator.Core.IServices;
using Translator.Core.Models;
using Translator.Core.Services;
using DynamicExpression = System.Linq.Dynamic.DynamicExpression;

namespace Translator.Admin
{
    public partial class MainForm : Form
    {
        private readonly IDictionaryService _dictionaryService;
        private readonly List<SearchBox> listSearchBox;
        public MainForm(IDictionaryService dictionaryService)
        {
            _dictionaryService = dictionaryService;
            InitializeComponent();
            listSearchBox = new List<SearchBox>
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            var predicate = string.Empty;
            var parameterList = new List<Expression<Func<Dictionary, bool>>>();
            int parameterIndex = 0;
            
            foreach (var searchBox in listSearchBox)
            {
                var expression = searchBox.GetExpression();
                var andOr = string.Empty;
                if (expression != null)
                {
                    predicate += andOr + $"@{parameterIndex}";
                    parameterList.Add(expression);
                    parameterIndex++;
                }
            }
            IQueryable<Dictionary> query = _dictionaryService.GetAll().Where(predicate, parameterList);

        }
    }
}
