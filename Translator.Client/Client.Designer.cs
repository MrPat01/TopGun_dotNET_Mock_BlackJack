namespace Translator.Client
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_JP = new System.Windows.Forms.TextBox();
            this.txt_VN = new System.Windows.Forms.TextBox();
            this.btn_JP2VN = new System.Windows.Forms.Button();
            this.btn_VN2JP = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_translateFolder = new System.Windows.Forms.Button();
            this.btn_translateFile = new System.Windows.Forms.Button();
            this.btn_BrowseFolder = new System.Windows.Forms.Button();
            this.btn_BrowseFile = new System.Windows.Forms.Button();
            this.txt_FolderPath = new System.Windows.Forms.TextBox();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(770, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " [FPT Direct Marketing : VN - JP Translation Tool]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(762, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Translate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(3, 330);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(750, 88);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_JP);
            this.groupBox3.Controls.Add(this.txt_VN);
            this.groupBox3.Controls.Add(this.btn_JP2VN);
            this.groupBox3.Controls.Add(this.btn_VN2JP);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(6, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(750, 162);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Text Translate";
            // 
            // txt_JP
            // 
            this.txt_JP.Location = new System.Drawing.Point(457, 41);
            this.txt_JP.Multiline = true;
            this.txt_JP.Name = "txt_JP";
            this.txt_JP.Size = new System.Drawing.Size(286, 104);
            this.txt_JP.TabIndex = 5;
            // 
            // txt_VN
            // 
            this.txt_VN.Location = new System.Drawing.Point(12, 43);
            this.txt_VN.Multiline = true;
            this.txt_VN.Name = "txt_VN";
            this.txt_VN.Size = new System.Drawing.Size(287, 102);
            this.txt_VN.TabIndex = 4;
            // 
            // btn_JP2VN
            // 
            this.btn_JP2VN.Location = new System.Drawing.Point(341, 110);
            this.btn_JP2VN.Name = "btn_JP2VN";
            this.btn_JP2VN.Size = new System.Drawing.Size(75, 23);
            this.btn_JP2VN.TabIndex = 3;
            this.btn_JP2VN.Text = "< JP2VN <";
            this.btn_JP2VN.UseVisualStyleBackColor = true;
            this.btn_JP2VN.Click += new System.EventHandler(this.btn_JP2VN_Click);
            // 
            // btn_VN2JP
            // 
            this.btn_VN2JP.Location = new System.Drawing.Point(341, 63);
            this.btn_VN2JP.Name = "btn_VN2JP";
            this.btn_VN2JP.Size = new System.Drawing.Size(75, 23);
            this.btn_VN2JP.TabIndex = 2;
            this.btn_VN2JP.Text = "> VN2JP >";
            this.btn_VN2JP.UseVisualStyleBackColor = true;
            this.btn_VN2JP.Click += new System.EventHandler(this.btn_VN2JP_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(454, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Japanese Text";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vietnamese Text";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_translateFolder);
            this.groupBox2.Controls.Add(this.btn_translateFile);
            this.groupBox2.Controls.Add(this.btn_BrowseFolder);
            this.groupBox2.Controls.Add(this.btn_BrowseFile);
            this.groupBox2.Controls.Add(this.txt_FolderPath);
            this.groupBox2.Controls.Add(this.txt_FilePath);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(243, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File n in Folder Translate";
            // 
            // btn_translateFolder
            // 
            this.btn_translateFolder.Location = new System.Drawing.Point(101, 112);
            this.btn_translateFolder.Name = "btn_translateFolder";
            this.btn_translateFolder.Size = new System.Drawing.Size(75, 23);
            this.btn_translateFolder.TabIndex = 7;
            this.btn_translateFolder.Text = "Translate";
            this.btn_translateFolder.UseVisualStyleBackColor = true;
            // 
            // btn_translateFile
            // 
            this.btn_translateFile.Location = new System.Drawing.Point(101, 45);
            this.btn_translateFile.Name = "btn_translateFile";
            this.btn_translateFile.Size = new System.Drawing.Size(75, 23);
            this.btn_translateFile.TabIndex = 6;
            this.btn_translateFile.Text = "Translate";
            this.btn_translateFile.UseVisualStyleBackColor = true;
            // 
            // btn_BrowseFolder
            // 
            this.btn_BrowseFolder.Location = new System.Drawing.Point(428, 84);
            this.btn_BrowseFolder.Name = "btn_BrowseFolder";
            this.btn_BrowseFolder.Size = new System.Drawing.Size(75, 23);
            this.btn_BrowseFolder.TabIndex = 5;
            this.btn_BrowseFolder.Text = "Browse";
            this.btn_BrowseFolder.UseVisualStyleBackColor = true;
            this.btn_BrowseFolder.Click += new System.EventHandler(this.btn_BrowseFolder_Click);
            // 
            // btn_BrowseFile
            // 
            this.btn_BrowseFile.Location = new System.Drawing.Point(428, 18);
            this.btn_BrowseFile.Name = "btn_BrowseFile";
            this.btn_BrowseFile.Size = new System.Drawing.Size(75, 23);
            this.btn_BrowseFile.TabIndex = 4;
            this.btn_BrowseFile.Text = "Browse";
            this.btn_BrowseFile.UseVisualStyleBackColor = true;
            this.btn_BrowseFile.Click += new System.EventHandler(this.btn_BrowseFile_Click);
            // 
            // txt_FolderPath
            // 
            this.txt_FolderPath.Location = new System.Drawing.Point(101, 86);
            this.txt_FolderPath.Name = "txt_FolderPath";
            this.txt_FolderPath.Size = new System.Drawing.Size(321, 20);
            this.txt_FolderPath.TabIndex = 3;
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Location = new System.Drawing.Point(101, 19);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(321, 20);
            this.txt_FilePath.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Input Folder:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Input File:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox2.Location = new System.Drawing.Point(104, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Refresh Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Translate Type:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(799, 501);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_translateFolder;
        private System.Windows.Forms.Button btn_translateFile;
        private System.Windows.Forms.Button btn_JP2VN;
        private System.Windows.Forms.Button btn_VN2JP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_FolderPath;
        public System.Windows.Forms.TextBox txt_JP;
        public System.Windows.Forms.TextBox txt_VN;
        public System.Windows.Forms.TextBox txt_FilePath;
        public System.Windows.Forms.Button btn_BrowseFile;
        public System.Windows.Forms.Button btn_BrowseFolder;
    }
}

