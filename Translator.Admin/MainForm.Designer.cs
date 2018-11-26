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
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchBox1 = new Translator.Admin.SearchBox(_fieldService);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // 
            // btn_add_new
            // 
            this.btn_add_new.Location = new System.Drawing.Point(378, 629);
            this.btn_add_new.Name = "btn_add_new";
            this.btn_add_new.Size = new System.Drawing.Size(103, 23);
            this.btn_add_new.TabIndex = 78;
            this.btn_add_new.Text = "Add new (F8)";
            this.btn_add_new.UseVisualStyleBackColor = true;
            // 
            // btn_delete_data
            // 
            this.btn_delete_data.Location = new System.Drawing.Point(51, 629);
            this.btn_delete_data.Name = "btn_delete_data";
            this.btn_delete_data.Size = new System.Drawing.Size(158, 23);
            this.btn_delete_data.TabIndex = 77;
            this.btn_delete_data.Text = "Xóa dữ liệu đã chọn (F12)";
            this.btn_delete_data.UseVisualStyleBackColor = true;
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
            this.groupBox2.Controls.Add(this.searchBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(827, 473);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Muti condition";
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 223);
            this.dataGridView1.TabIndex = 109;
            // 
            // searchBox1
            // 
            this.searchBox1.Location = new System.Drawing.Point(7, 20);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.Size = new System.Drawing.Size(373, 45);
            this.searchBox1.TabIndex = 111;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private SearchBox searchBox1;
    }
}