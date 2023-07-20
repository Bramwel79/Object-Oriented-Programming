namespace CarDealer.cs
{
    partial class mainForm
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
            this.jaguarRadioButton = new System.Windows.Forms.RadioButton();
            this.bmwRadioButton = new System.Windows.Forms.RadioButton();
            this.toyotaRadioButton = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jaguarRadioButton);
            this.groupBox1.Controls.Add(this.bmwRadioButton);
            this.groupBox1.Controls.Add(this.toyotaRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(47, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Models";
            // 
            // jaguarRadioButton
            // 
            this.jaguarRadioButton.AutoSize = true;
            this.jaguarRadioButton.Location = new System.Drawing.Point(6, 67);
            this.jaguarRadioButton.Name = "jaguarRadioButton";
            this.jaguarRadioButton.Size = new System.Drawing.Size(57, 17);
            this.jaguarRadioButton.TabIndex = 2;
            this.jaguarRadioButton.TabStop = true;
            this.jaguarRadioButton.Text = "Jaguar";
            this.jaguarRadioButton.UseVisualStyleBackColor = true;
            // 
            // bmwRadioButton
            // 
            this.bmwRadioButton.AutoSize = true;
            this.bmwRadioButton.Location = new System.Drawing.Point(6, 44);
            this.bmwRadioButton.Name = "bmwRadioButton";
            this.bmwRadioButton.Size = new System.Drawing.Size(52, 17);
            this.bmwRadioButton.TabIndex = 1;
            this.bmwRadioButton.TabStop = true;
            this.bmwRadioButton.Text = "BMW";
            this.bmwRadioButton.UseVisualStyleBackColor = true;
            // 
            // toyotaRadioButton
            // 
            this.toyotaRadioButton.AutoSize = true;
            this.toyotaRadioButton.Location = new System.Drawing.Point(7, 21);
            this.toyotaRadioButton.Name = "toyotaRadioButton";
            this.toyotaRadioButton.Size = new System.Drawing.Size(58, 17);
            this.toyotaRadioButton.TabIndex = 0;
            this.toyotaRadioButton.TabStop = true;
            this.toyotaRadioButton.Text = "Toyota";
            this.toyotaRadioButton.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(172, 197);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(47, 197);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // mainForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Name = "mainForm";
            this.Text = "Automobile dealer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton jaguarRadioButton;
        private System.Windows.Forms.RadioButton bmwRadioButton;
        private System.Windows.Forms.RadioButton toyotaRadioButton;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOK;
    }
}

