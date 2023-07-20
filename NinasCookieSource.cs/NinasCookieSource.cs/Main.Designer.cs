namespace NinasCookieSource.cs
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vanillaRadioButton = new System.Windows.Forms.RadioButton();
            this.chocolateRadioButton = new System.Windows.Forms.RadioButton();
            this.gingerRadioButton = new System.Windows.Forms.RadioButton();
            this.choiceListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.orderDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vanillaRadioButton);
            this.groupBox1.Controls.Add(this.chocolateRadioButton);
            this.groupBox1.Controls.Add(this.gingerRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(47, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cookie types";
            // 
            // vanillaRadioButton
            // 
            this.vanillaRadioButton.AutoSize = true;
            this.vanillaRadioButton.Location = new System.Drawing.Point(6, 65);
            this.vanillaRadioButton.Name = "vanillaRadioButton";
            this.vanillaRadioButton.Size = new System.Drawing.Size(96, 17);
            this.vanillaRadioButton.TabIndex = 2;
            this.vanillaRadioButton.TabStop = true;
            this.vanillaRadioButton.Text = "Vanilla cookies";
            this.vanillaRadioButton.UseVisualStyleBackColor = true;
            // 
            // chocolateRadioButton
            // 
            this.chocolateRadioButton.AutoSize = true;
            this.chocolateRadioButton.Location = new System.Drawing.Point(6, 42);
            this.chocolateRadioButton.Name = "chocolateRadioButton";
            this.chocolateRadioButton.Size = new System.Drawing.Size(113, 17);
            this.chocolateRadioButton.TabIndex = 1;
            this.chocolateRadioButton.TabStop = true;
            this.chocolateRadioButton.Text = "Chocolate cookies";
            this.chocolateRadioButton.UseVisualStyleBackColor = true;
            // 
            // gingerRadioButton
            // 
            this.gingerRadioButton.AutoSize = true;
            this.gingerRadioButton.Location = new System.Drawing.Point(6, 19);
            this.gingerRadioButton.Name = "gingerRadioButton";
            this.gingerRadioButton.Size = new System.Drawing.Size(96, 17);
            this.gingerRadioButton.TabIndex = 0;
            this.gingerRadioButton.TabStop = true;
            this.gingerRadioButton.Text = "Ginger cookies";
            this.gingerRadioButton.UseVisualStyleBackColor = true;
            // 
            // choiceListBox
            // 
            this.choiceListBox.FormattingEnabled = true;
            this.choiceListBox.Items.AddRange(new object[] {
            "1/2 dozen",
            "1 dozen",
            "2 dozens",
            "3 dozens"});
            this.choiceListBox.Location = new System.Drawing.Point(295, 39);
            this.choiceListBox.Name = "choiceListBox";
            this.choiceListBox.Size = new System.Drawing.Size(120, 95);
            this.choiceListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Quantity:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(190, 286);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(118, 42);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(332, 286);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 42);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(53, 234);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(531, 24);
            this.lblPrice.TabIndex = 5;
            // 
            // orderDateCalendar
            // 
            this.orderDateCalendar.Location = new System.Drawing.Point(447, 39);
            this.orderDateCalendar.Name = "orderDateCalendar";
            this.orderDateCalendar.TabIndex = 6;
            this.orderDateCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.orderDateCalendar_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choose Order Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choose Cookie Type:";
            // 
            // Main
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(705, 359);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderDateCalendar);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choiceListBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Nina\'s Cookie";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton vanillaRadioButton;
        private System.Windows.Forms.RadioButton chocolateRadioButton;
        private System.Windows.Forms.RadioButton gingerRadioButton;
        private System.Windows.Forms.ListBox choiceListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.MonthCalendar orderDateCalendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

