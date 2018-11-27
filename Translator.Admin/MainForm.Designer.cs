namespace Translator.Admin
{
    partial class MainForm
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
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_add_new = new System.Windows.Forms.Button();
            this.btn_delete_data = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.patternTypecbb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchBox10 = new Translator.Admin.SearchBox();
            this.searchBox9 = new Translator.Admin.SearchBox();
            this.searchBox8 = new Translator.Admin.SearchBox();
            this.searchBox7 = new Translator.Admin.SearchBox();
            this.searchBox6 = new Translator.Admin.SearchBox();
            this.searchBox5 = new Translator.Admin.SearchBox();
            this.searchBox4 = new Translator.Admin.SearchBox();
            this.searchBox3 = new Translator.Admin.SearchBox();
            this.searchBox2 = new Translator.Admin.SearchBox();
            this.searchBox1 = new Translator.Admin.SearchBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GridData = new System.Windows.Forms.DataGridView();
            this.searchBox1 = new Translator.Admin.SearchBox(_fieldService);
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridData)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(706, 629);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 79;
            this.btn_search.Text = "Search (F5)";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_add_new
            // 
            this.btn_add_new.Location = new System.Drawing.Point(378, 629);
            this.btn_add_new.Name = "btn_add_new";
            this.btn_add_new.Size = new System.Drawing.Size(103, 23);
            this.btn_add_new.TabIndex = 78;
            this.btn_add_new.Text = "Add new (F8)";
            this.btn_add_new.UseVisualStyleBackColor = true;
            this.btn_add_new.Click += new System.EventHandler(this.btn_add_new_Click);
            // 
            // btn_delete_data
            // 
            this.btn_delete_data.Location = new System.Drawing.Point(51, 629);
            this.btn_delete_data.Name = "btn_delete_data";
            this.btn_delete_data.Size = new System.Drawing.Size(158, 23);
            this.btn_delete_data.TabIndex = 77;
            this.btn_delete_data.Text = "Xóa dữ liệu đã chọn (F12)";
            this.btn_delete_data.UseVisualStyleBackColor = true;
            this.btn_delete_data.Click += new System.EventHandler(this.btn_delete_data_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Pattern type";
            // 
            // patternTypecbb
            // 
            this.patternTypecbb.FormattingEnabled = true;
            this.patternTypecbb.Location = new System.Drawing.Point(197, 40);
            this.patternTypecbb.Name = "patternTypecbb";
            this.patternTypecbb.Size = new System.Drawing.Size(502, 21);
            this.patternTypecbb.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.patternTypecbb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 103);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick Search";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchBox10);
            this.groupBox2.Controls.Add(this.searchBox9);
            this.groupBox2.Controls.Add(this.searchBox8);
            this.groupBox2.Controls.Add(this.searchBox7);
            this.groupBox2.Controls.Add(this.searchBox6);
            this.groupBox2.Controls.Add(this.searchBox5);
            this.groupBox2.Controls.Add(this.searchBox4);
            this.groupBox2.Controls.Add(this.searchBox3);
            this.groupBox2.Controls.Add(this.searchBox2);
            this.groupBox2.Controls.Add(this.searchBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.GridData);
            this.groupBox2.Location = new System.Drawing.Point(12, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(827, 473);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Muti condition";
            // 
            // searchBox10
            // 
            this.searchBox10.EnableAndOrCombobox = true;
            this.searchBox10.Location = new System.Drawing.Point(417, 127);
            this.searchBox10.Name = "searchBox10";
            this.searchBox10.Size = new System.Drawing.Size(380, 31);
            this.searchBox10.TabIndex = 120;
            // 
            // searchBox9
            // 
            this.searchBox9.EnableAndOrCombobox = true;
            this.searchBox9.Location = new System.Drawing.Point(7, 127);
            this.searchBox9.Name = "searchBox9";
            this.searchBox9.Size = new System.Drawing.Size(380, 31);
            this.searchBox9.TabIndex = 119;
            // 
            // searchBox8
            // 
            this.searchBox8.EnableAndOrCombobox = true;
            this.searchBox8.Location = new System.Drawing.Point(417, 101);
            this.searchBox8.Name = "searchBox8";
            this.searchBox8.Size = new System.Drawing.Size(380, 31);
            this.searchBox8.TabIndex = 118;
            // 
            // searchBox7
            // 
            this.searchBox7.EnableAndOrCombobox = true;
            this.searchBox7.Location = new System.Drawing.Point(6, 101);
            this.searchBox7.Name = "searchBox7";
            this.searchBox7.Size = new System.Drawing.Size(380, 31);
            this.searchBox7.TabIndex = 117;
            // 
            // searchBox6
            // 
            this.searchBox6.EnableAndOrCombobox = true;
            this.searchBox6.Location = new System.Drawing.Point(417, 75);
            this.searchBox6.Name = "searchBox6";
            this.searchBox6.Size = new System.Drawing.Size(380, 31);
            this.searchBox6.TabIndex = 116;
            // 
            // searchBox5
            // 
            this.searchBox5.EnableAndOrCombobox = true;
            this.searchBox5.Location = new System.Drawing.Point(6, 75);
            this.searchBox5.Name = "searchBox5";
            this.searchBox5.Size = new System.Drawing.Size(380, 31);
            this.searchBox5.TabIndex = 115;
            // 
            // searchBox4
            // 
            this.searchBox4.EnableAndOrCombobox = true;
            this.searchBox4.Location = new System.Drawing.Point(417, 47);
            this.searchBox4.Name = "searchBox4";
            this.searchBox4.Size = new System.Drawing.Size(380, 31);
            this.searchBox4.TabIndex = 114;
            // 
            // searchBox3
            // 
            this.searchBox3.EnableAndOrCombobox = true;
            this.searchBox3.Location = new System.Drawing.Point(6, 47);
            this.searchBox3.Name = "searchBox3";
            this.searchBox3.Size = new System.Drawing.Size(380, 31);
            this.searchBox3.TabIndex = 113;
            // 
            // searchBox2
            // 
            this.searchBox2.EnableAndOrCombobox = true;
            this.searchBox2.Location = new System.Drawing.Point(417, 20);
            this.searchBox2.Name = "searchBox2";
            this.searchBox2.Size = new System.Drawing.Size(380, 31);
            this.searchBox2.TabIndex = 112;
            // 
            // searchBox1
            // 
            this.searchBox1.EnableAndOrCombobox = false;
            this.searchBox1.Location = new System.Drawing.Point(7, 20);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.Size = new System.Drawing.Size(380, 31);
            this.searchBox1.TabIndex = 111;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 110;
            this.label4.Text = "Search result";
            // 
            // GridData
            // 
            this.GridData.AllowDrop = true;
            this.GridData.AllowUserToAddRows = false;
            this.GridData.AllowUserToDeleteRows = false;
            this.GridData.AllowUserToOrderColumns = true;
            this.GridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check});
            this.GridData.Location = new System.Drawing.Point(27, 232);
            this.GridData.Name = "GridData";
            this.GridData.Size = new System.Drawing.Size(770, 223);
            this.GridData.TabIndex = 109;
            this.GridData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridData_CellValueChanged);
            this.GridData.DoubleClick += new System.EventHandler(this.GridData_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 664);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_add_new);
            this.Controls.Add(this.btn_delete_data);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_add_new;
        private System.Windows.Forms.Button btn_delete_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox patternTypecbb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SearchBox searchBox10;
        private SearchBox searchBox9;
        private SearchBox searchBox8;
        private SearchBox searchBox7;
        private SearchBox searchBox6;
        private SearchBox searchBox5;
        private SearchBox searchBox4;
        private SearchBox searchBox3;
        private SearchBox searchBox2;
        private SearchBox searchBox1;
        public System.Windows.Forms.DataGridView GridData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
    }
}