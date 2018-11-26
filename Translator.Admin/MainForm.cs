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

namespace Translator.Admin
{
    public partial class MainForm : Form
    {
        private IFieldService _fieldService;
        public MainForm(IFieldService fieldService)
        {
            _fieldService = fieldService;
            InitializeComponent();
        }


    }
}
