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
            this.SuspendLayout();
            // 
            // cbProperty
            // 
            this.cbProperty.FormattingEnabled = true;
            this.cbProperty.Location = new System.Drawing.Point(8, 12);
            this.cbProperty.Name = "cbProperty";
            this.cbProperty.Size = new System.Drawing.Size(121, 21);
            this.cbProperty.TabIndex = 1;
            // 
            // cbOperation
            // 
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Location = new System.Drawing.Point(135, 12);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(121, 21);
            this.cbOperation.TabIndex = 2;
            // 
            // tbSearchValue
            // 
            this.tbSearchValue.Location = new System.Drawing.Point(262, 13);
            this.tbSearchValue.Name = "tbSearchValue";
            this.tbSearchValue.Size = new System.Drawing.Size(100, 20);
            this.tbSearchValue.TabIndex = 3;
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbSearchValue);
            this.Controls.Add(this.cbOperation);
            this.Controls.Add(this.cbProperty);
            this.Name = "SearchBox";
            this.Size = new System.Drawing.Size(373, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProperty;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.TextBox tbSearchValue;
    }
}
