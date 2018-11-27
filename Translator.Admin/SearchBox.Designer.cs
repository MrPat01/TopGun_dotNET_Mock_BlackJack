namespace Translator.Admin
{
    partial class SearchBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbProperty = new System.Windows.Forms.ComboBox();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.tbSearchValue = new System.Windows.Forms.TextBox();
            this.cbAndOr = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbProperty
            // 
            this.cbProperty.FormattingEnabled = true;
            this.cbProperty.Location = new System.Drawing.Point(66, 5);
            this.cbProperty.Name = "cbProperty";
            this.cbProperty.Size = new System.Drawing.Size(121, 21);
            this.cbProperty.TabIndex = 1;
            this.cbProperty.SelectedIndexChanged += new System.EventHandler(this.cbProperty_SelectedIndexChanged);
            // 
            // cbOperation
            // 
            this.cbOperation.Enabled = false;
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Location = new System.Drawing.Point(193, 5);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(73, 21);
            this.cbOperation.TabIndex = 2;
            this.cbOperation.SelectedIndexChanged += new System.EventHandler(this.cbOperation_SelectedIndexChanged);
            // 
            // tbSearchValue
            // 
            this.tbSearchValue.Enabled = false;
            this.tbSearchValue.Location = new System.Drawing.Point(272, 5);
            this.tbSearchValue.Name = "tbSearchValue";
            this.tbSearchValue.Size = new System.Drawing.Size(100, 20);
            this.tbSearchValue.TabIndex = 3;
            // 
            // cbAndOr
            // 
            this.cbAndOr.FormattingEnabled = true;
            this.cbAndOr.Location = new System.Drawing.Point(5, 5);
            this.cbAndOr.Name = "cbAndOr";
            this.cbAndOr.Size = new System.Drawing.Size(58, 21);
            this.cbAndOr.TabIndex = 4;
            this.cbAndOr.Visible = false;
            this.cbAndOr.SelectedIndexChanged += new System.EventHandler(this.cbAndOr_SelectedIndexChanged);
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbAndOr);
            this.Controls.Add(this.tbSearchValue);
            this.Controls.Add(this.cbOperation);
            this.Controls.Add(this.cbProperty);
            this.Name = "SearchBox";
            this.Size = new System.Drawing.Size(380, 31);
            this.Load += new System.EventHandler(this.SearchBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProperty;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.TextBox tbSearchValue;
        private System.Windows.Forms.ComboBox cbAndOr;
    }
}
