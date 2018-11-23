using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator.Server
{
    
    public partial class Server : Form
    {
        private readonly Core.IServices.IConfigPathService _configPathService;
        public Server(Core.IServices.IConfigPathService ConfigPathService)
        {
            _configPathService = ConfigPathService;
            InitializeComponent();
            this.Text = "Black Jack - Server -v01.00";
        }

        private void Server_Load(object sender, EventArgs e)
        {
            var configPath = _configPathService.GetAll().ToList();
            txt_JP_Input.Text = configPath.FirstOrDefault(x => x.Name == "JP2VNInput").Path;
            txt_JP_BackUp.Text = configPath.FirstOrDefault(x => x.Name == "JP2VNBackUp").Path;
            txt_JP_Output.Text = configPath.FirstOrDefault(x => x.Name == "JP2VNOutput").Path;
            txt_JP_Error.Text = configPath.FirstOrDefault(x => x.Name == "JP2VNError").Path;
            txt_VN_Input.Text = configPath.FirstOrDefault(x => x.Name == "VN2JPInput").Path;
            txt_VN_Backup.Text = configPath.FirstOrDefault(x => x.Name == "VN2JPBackUp").Path;
            txt_VN_Output.Text = configPath.FirstOrDefault(x => x.Name == "VN2JPOutput").Path;
            txt_VN_Error.Text = configPath.FirstOrDefault(x => x.Name == "VN2JPError").Path;
        }

        private void btn_JP_Input_Click(object sender, EventArgs e)
        {
            var path = txt_JP_Input.Text;
            if(!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Process.Start(path);
        }

        private void btn_JP_BackUp_Click(object sender, EventArgs e)
        {
            var path = txt_JP_BackUp.Text;
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Process.Start(path);
        }

        private void btn_JP_Output_Click(object sender, EventArgs e)
        {
            var path = txt_JP_Output.Text;
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Process.Start(path);
        }

        private void btn_JP_Error_Click(object sender, EventArgs e)
        {
            var path = txt_JP_Error.Text;
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Process.Start(path);
        }

        private void btn_VN_Input_Click(object sender, EventArgs e)
        {
            var path = txt_VN_Input.Text;
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Process.Start(path);
        }

        private void btn_VN_Backup_Click(object sender, EventArgs e)
        {
            var path = txt_VN_Backup.Text;
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Process.Start(path);
        }

        private void btn_VN_Output_Click(object sender, EventArgs e)
        {
            var path = txt_VN_Output.Text;
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Process.Start(path);
        }

        private void btn_VN_Error_Click(object sender, EventArgs e)
        {
            var path = txt_VN_Error.Text;
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Process.Start(path);
        }
    }
}
