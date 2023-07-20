namespace FontSelector.cs
{
    partial class FontSelector
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
            this.fontNamelistBox = new System.Windows.Forms.ListBox();
            this.fontSizelistBox = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fontNamelistBox
            // 
            this.fontNamelistBox.FormattingEnabled = true;
            this.fontNamelistBox.Items.AddRange(new object[] {
            "San serif",
            "Courier",
            "Papyrus",
            "Times Roman"});
            this.fontNamelistBox.Location = new System.Drawing.Point(12, 35);
            this.fontNamelistBox.Name = "fontNamelistBox";
            this.fontNamelistBox.Size = new System.Drawing.Size(120, 95);
            this.fontNamelistBox.TabIndex = 0;
            // 
            // fontSizelistBox
            // 
            this.fontSizelistBox.FormattingEnabled = true;
            this.fontSizelistBox.Items.AddRange(new object[] {
            "5",
            "8",
            "10",
            "12"});
            this.fontSizelistBox.Location = new System.Drawing.Point(152, 35);
            this.fontSizelistBox.Name = "fontSizelistBox";
            this.fontSizelistBox.Size = new System.Drawing.Size(120, 95);
            this.fontSizelistBox.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(102, 176);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(119, 224);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(31, 13);
            this.lblHello.TabIndex = 3;
            this.lblHello.Text = "Hello";
            // 
            // FontSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.fontSizelistBox);
            this.Controls.Add(this.fontNamelistBox);
            this.Name = "FontSelector";
            this.Text = "Font Selector";
            this.Load += new System.EventHandler(this.FontSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fontNamelistBox;
        private System.Windows.Forms.ListBox fontSizelistBox;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblHello;
    }
}

