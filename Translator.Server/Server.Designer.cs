﻿namespace Translator.Server
{
    partial class Server
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
            this.btn_Run = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_VN_Error = new System.Windows.Forms.Button();
            this.btn_VN_Output = new System.Windows.Forms.Button();
            this.txt_VN_Error = new System.Windows.Forms.TextBox();
            this.txt_VN_Output = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_VN_Backup = new System.Windows.Forms.Button();
            this.btn_VN_Input = new System.Windows.Forms.Button();
            this.txt_VN_Backup = new System.Windows.Forms.TextBox();
            this.txt_VN_Input = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_JP_Error = new System.Windows.Forms.Button();
            this.btn_JP_Output = new System.Windows.Forms.Button();
            this.txt_JP_Error = new System.Windows.Forms.TextBox();
            this.txt_JP_Output = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_JP_BackUp = new System.Windows.Forms.Button();
            this.btn_JP_Input = new System.Windows.Forms.Button();
            this.txt_JP_BackUp = new System.Windows.Forms.TextBox();
            this.txt_JP_Input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 536);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Run);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(762, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Translate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(162, 349);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(75, 23);
            this.btn_Run.TabIndex = 5;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_VN_Error);
            this.groupBox3.Controls.Add(this.btn_VN_Output);
            this.groupBox3.Controls.Add(this.txt_VN_Error);
            this.groupBox3.Controls.Add(this.txt_VN_Output);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btn_VN_Backup);
            this.groupBox3.Controls.Add(this.btn_VN_Input);
            this.groupBox3.Controls.Add(this.txt_VN_Backup);
            this.groupBox3.Controls.Add(this.txt_VN_Input);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(243, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(513, 180);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Translate VN 2 JP";
            // 
            // btn_VN_Error
            // 
            this.btn_VN_Error.Location = new System.Drawing.Point(428, 105);
            this.btn_VN_Error.Name = "btn_VN_Error";
            this.btn_VN_Error.Size = new System.Drawing.Size(75, 23);
            this.btn_VN_Error.TabIndex = 11;
            this.btn_VN_Error.Text = "Go";
            this.btn_VN_Error.UseVisualStyleBackColor = true;
            this.btn_VN_Error.Click += new System.EventHandler(this.btn_VN_Error_Click);
            // 
            // btn_VN_Output
            // 
            this.btn_VN_Output.Location = new System.Drawing.Point(428, 76);
            this.btn_VN_Output.Name = "btn_VN_Output";
            this.btn_VN_Output.Size = new System.Drawing.Size(75, 23);
            this.btn_VN_Output.TabIndex = 10;
            this.btn_VN_Output.Text = "Go";
            this.btn_VN_Output.UseVisualStyleBackColor = true;
            this.btn_VN_Output.Click += new System.EventHandler(this.btn_VN_Output_Click);
            // 
            // txt_VN_Error
            // 
            this.txt_VN_Error.Enabled = false;
            this.txt_VN_Error.Location = new System.Drawing.Point(101, 107);
            this.txt_VN_Error.Name = "txt_VN_Error";
            this.txt_VN_Error.Size = new System.Drawing.Size(321, 20);
            this.txt_VN_Error.TabIndex = 9;
            // 
            // txt_VN_Output
            // 
            this.txt_VN_Output.Enabled = false;
            this.txt_VN_Output.Location = new System.Drawing.Point(101, 78);
            this.txt_VN_Output.Name = "txt_VN_Output";
            this.txt_VN_Output.Size = new System.Drawing.Size(321, 20);
            this.txt_VN_Output.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Error Folder:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Output Folder:";
            // 
            // btn_VN_Backup
            // 
            this.btn_VN_Backup.Location = new System.Drawing.Point(428, 47);
            this.btn_VN_Backup.Name = "btn_VN_Backup";
            this.btn_VN_Backup.Size = new System.Drawing.Size(75, 23);
            this.btn_VN_Backup.TabIndex = 5;
            this.btn_VN_Backup.Text = "Go";
            this.btn_VN_Backup.UseVisualStyleBackColor = true;
            this.btn_VN_Backup.Click += new System.EventHandler(this.btn_VN_Backup_Click);
            // 
            // btn_VN_Input
            // 
            this.btn_VN_Input.Location = new System.Drawing.Point(428, 18);
            this.btn_VN_Input.Name = "btn_VN_Input";
            this.btn_VN_Input.Size = new System.Drawing.Size(75, 23);
            this.btn_VN_Input.TabIndex = 4;
            this.btn_VN_Input.Text = "Go";
            this.btn_VN_Input.UseVisualStyleBackColor = true;
            this.btn_VN_Input.Click += new System.EventHandler(this.btn_VN_Input_Click);
            // 
            // txt_VN_Backup
            // 
            this.txt_VN_Backup.Enabled = false;
            this.txt_VN_Backup.Location = new System.Drawing.Point(101, 49);
            this.txt_VN_Backup.Name = "txt_VN_Backup";
            this.txt_VN_Backup.Size = new System.Drawing.Size(321, 20);
            this.txt_VN_Backup.TabIndex = 3;
            // 
            // txt_VN_Input
            // 
            this.txt_VN_Input.Enabled = false;
            this.txt_VN_Input.Location = new System.Drawing.Point(101, 19);
            this.txt_VN_Input.Name = "txt_VN_Input";
            this.txt_VN_Input.Size = new System.Drawing.Size(321, 20);
            this.txt_VN_Input.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Backup Folder:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Input Folder:";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(6, 378);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(750, 116);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_JP_Error);
            this.groupBox2.Controls.Add(this.btn_JP_Output);
            this.groupBox2.Controls.Add(this.txt_JP_Error);
            this.groupBox2.Controls.Add(this.txt_JP_Output);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_JP_BackUp);
            this.groupBox2.Controls.Add(this.btn_JP_Input);
            this.groupBox2.Controls.Add(this.txt_JP_BackUp);
            this.groupBox2.Controls.Add(this.txt_JP_Input);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(243, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Translate JP 2 VN";
            // 
            // btn_JP_Error
            // 
            this.btn_JP_Error.Location = new System.Drawing.Point(428, 105);
            this.btn_JP_Error.Name = "btn_JP_Error";
            this.btn_JP_Error.Size = new System.Drawing.Size(75, 23);
            this.btn_JP_Error.TabIndex = 11;
            this.btn_JP_Error.Text = "Go";
            this.btn_JP_Error.UseVisualStyleBackColor = true;
            this.btn_JP_Error.Click += new System.EventHandler(this.btn_JP_Error_Click);
            // 
            // btn_JP_Output
            // 
            this.btn_JP_Output.Location = new System.Drawing.Point(428, 76);
            this.btn_JP_Output.Name = "btn_JP_Output";
            this.btn_JP_Output.Size = new System.Drawing.Size(75, 23);
            this.btn_JP_Output.TabIndex = 10;
            this.btn_JP_Output.Text = "Go";
            this.btn_JP_Output.UseVisualStyleBackColor = true;
            this.btn_JP_Output.Click += new System.EventHandler(this.btn_JP_Output_Click);
            // 
            // txt_JP_Error
            // 
            this.txt_JP_Error.Enabled = false;
            this.txt_JP_Error.Location = new System.Drawing.Point(101, 107);
            this.txt_JP_Error.Name = "txt_JP_Error";
            this.txt_JP_Error.Size = new System.Drawing.Size(321, 20);
            this.txt_JP_Error.TabIndex = 9;
            // 
            // txt_JP_Output
            // 
            this.txt_JP_Output.Enabled = false;
            this.txt_JP_Output.Location = new System.Drawing.Point(101, 78);
            this.txt_JP_Output.Name = "txt_JP_Output";
            this.txt_JP_Output.Size = new System.Drawing.Size(321, 20);
            this.txt_JP_Output.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Error Folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output Folder:";
            // 
            // btn_JP_BackUp
            // 
            this.btn_JP_BackUp.Location = new System.Drawing.Point(428, 47);
            this.btn_JP_BackUp.Name = "btn_JP_BackUp";
            this.btn_JP_BackUp.Size = new System.Drawing.Size(75, 23);
            this.btn_JP_BackUp.TabIndex = 5;
            this.btn_JP_BackUp.Text = "Go";
            this.btn_JP_BackUp.UseVisualStyleBackColor = true;
            this.btn_JP_BackUp.Click += new System.EventHandler(this.btn_JP_BackUp_Click);
            // 
            // btn_JP_Input
            // 
            this.btn_JP_Input.Location = new System.Drawing.Point(428, 18);
            this.btn_JP_Input.Name = "btn_JP_Input";
            this.btn_JP_Input.Size = new System.Drawing.Size(75, 23);
            this.btn_JP_Input.TabIndex = 4;
            this.btn_JP_Input.Text = "Go";
            this.btn_JP_Input.UseVisualStyleBackColor = true;
            this.btn_JP_Input.Click += new System.EventHandler(this.btn_JP_Input_Click);
            // 
            // txt_JP_BackUp
            // 
            this.txt_JP_BackUp.Enabled = false;
            this.txt_JP_BackUp.Location = new System.Drawing.Point(101, 49);
            this.txt_JP_BackUp.Name = "txt_JP_BackUp";
            this.txt_JP_BackUp.Size = new System.Drawing.Size(321, 20);
            this.txt_JP_BackUp.TabIndex = 3;
            // 
            // txt_JP_Input
            // 
            this.txt_JP_Input.Enabled = false;
            this.txt_JP_Input.Location = new System.Drawing.Point(101, 19);
            this.txt_JP_Input.Name = "txt_JP_Input";
            this.txt_JP_Input.Size = new System.Drawing.Size(321, 20);
            this.txt_JP_Input.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Backup Folder:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Input Folder:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Thistle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(605, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Boy Đóng Thuế";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Thistle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(420, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Searching Man";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Thistle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(251, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Thủ Khoa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Thistle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(59, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nhà Vô Địch";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Translator.Server.Properties.Resources._47225220_2238312743124879_8960527073496006656_n;
            this.pictureBox4.Location = new System.Drawing.Point(575, 203);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(168, 253);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Translator.Server.Properties.Resources._47111751_359602294789368_4643120531879493632_n;
            this.pictureBox3.Location = new System.Drawing.Point(389, 203);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(168, 253);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Translator.Server.Properties.Resources._47062141_2442933359274255_2161239968687587328_n;
            this.pictureBox2.Location = new System.Drawing.Point(204, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 253);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Translator.Server.Properties.Resources._46950763_2268882083131675_3153659962782121984_n;
            this.pictureBox1.Location = new System.Drawing.Point(20, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(249, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "WE ARE DES TEAM";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(799, 584);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Run;
        public System.Windows.Forms.TextBox txt_JP_Input;
        public System.Windows.Forms.TextBox txt_JP_BackUp;
        public System.Windows.Forms.TextBox txt_JP_Output;
        public System.Windows.Forms.TextBox txt_VN_Input;
        public System.Windows.Forms.TextBox txt_JP_Error;
        public System.Windows.Forms.TextBox txt_VN_Backup;
        public System.Windows.Forms.TextBox txt_VN_Output;
        public System.Windows.Forms.TextBox txt_VN_Error;
        public System.Windows.Forms.Button btn_JP_Input;
        public System.Windows.Forms.Button btn_JP_BackUp;
        public System.Windows.Forms.Button btn_JP_Output;
        public System.Windows.Forms.Button btn_JP_Error;
        public System.Windows.Forms.Button btn_VN_Input;
        public System.Windows.Forms.Button btn_VN_Backup;
        public System.Windows.Forms.Button btn_VN_Output;
        public System.Windows.Forms.Button btn_VN_Error;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
    }
}

