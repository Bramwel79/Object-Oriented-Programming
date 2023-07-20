namespace CarRental.cs
{
    partial class CarRental
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
            this.radioButtonLuxury = new System.Windows.Forms.RadioButton();
            this.radioButtonStandard = new System.Windows.Forms.RadioButton();
            this.radioButtonCompact = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonSeven = new System.Windows.Forms.RadioButton();
            this.radioButtonSix = new System.Windows.Forms.RadioButton();
            this.radioButtonFive = new System.Windows.Forms.RadioButton();
            this.radioButtonFour = new System.Windows.Forms.RadioButton();
            this.radioButtonThree = new System.Windows.Forms.RadioButton();
            this.radioButtonTwo = new System.Windows.Forms.RadioButton();
            this.radioButtonOne = new System.Windows.Forms.RadioButton();
            this.labelPrice = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.radioButtonLuxury);
            this.groupBox1.Controls.Add(this.radioButtonStandard);
            this.groupBox1.Controls.Add(this.radioButtonCompact);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Style";
            // 
            // radioButtonLuxury
            // 
            this.radioButtonLuxury.AutoSize = true;
            this.radioButtonLuxury.Location = new System.Drawing.Point(6, 65);
            this.radioButtonLuxury.Name = "radioButtonLuxury";
            this.radioButtonLuxury.Size = new System.Drawing.Size(56, 17);
            this.radioButtonLuxury.TabIndex = 2;
            this.radioButtonLuxury.TabStop = true;
            this.radioButtonLuxury.Text = "Luxury";
            this.radioButtonLuxury.UseVisualStyleBackColor = true;
            // 
            // radioButtonStandard
            // 
            this.radioButtonStandard.AutoSize = true;
            this.radioButtonStandard.Location = new System.Drawing.Point(6, 42);
            this.radioButtonStandard.Name = "radioButtonStandard";
            this.radioButtonStandard.Size = new System.Drawing.Size(68, 17);
            this.radioButtonStandard.TabIndex = 1;
            this.radioButtonStandard.TabStop = true;
            this.radioButtonStandard.Text = "Standard";
            this.radioButtonStandard.UseVisualStyleBackColor = true;
            // 
            // radioButtonCompact
            // 
            this.radioButtonCompact.AutoSize = true;
            this.radioButtonCompact.Location = new System.Drawing.Point(6, 18);
            this.radioButtonCompact.Name = "radioButtonCompact";
            this.radioButtonCompact.Size = new System.Drawing.Size(67, 17);
            this.radioButtonCompact.TabIndex = 0;
            this.radioButtonCompact.TabStop = true;
            this.radioButtonCompact.Text = "Compact";
            this.radioButtonCompact.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.radioButtonSeven);
            this.groupBox2.Controls.Add(this.radioButtonSix);
            this.groupBox2.Controls.Add(this.radioButtonFive);
            this.groupBox2.Controls.Add(this.radioButtonFour);
            this.groupBox2.Controls.Add(this.radioButtonThree);
            this.groupBox2.Controls.Add(this.radioButtonTwo);
            this.groupBox2.Controls.Add(this.radioButtonOne);
            this.groupBox2.Location = new System.Drawing.Point(161, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Days";
            // 
            // radioButtonSeven
            // 
            this.radioButtonSeven.AutoSize = true;
            this.radioButtonSeven.Location = new System.Drawing.Point(65, 88);
            this.radioButtonSeven.Name = "radioButtonSeven";
            this.radioButtonSeven.Size = new System.Drawing.Size(31, 17);
            this.radioButtonSeven.TabIndex = 6;
            this.radioButtonSeven.TabStop = true;
            this.radioButtonSeven.Text = "7";
            this.radioButtonSeven.UseVisualStyleBackColor = true;
            // 
            // radioButtonSix
            // 
            this.radioButtonSix.AutoSize = true;
            this.radioButtonSix.Location = new System.Drawing.Point(65, 65);
            this.radioButtonSix.Name = "radioButtonSix";
            this.radioButtonSix.Size = new System.Drawing.Size(31, 17);
            this.radioButtonSix.TabIndex = 5;
            this.radioButtonSix.TabStop = true;
            this.radioButtonSix.Text = "6";
            this.radioButtonSix.UseVisualStyleBackColor = true;
            // 
            // radioButtonFive
            // 
            this.radioButtonFive.AutoSize = true;
            this.radioButtonFive.Location = new System.Drawing.Point(65, 42);
            this.radioButtonFive.Name = "radioButtonFive";
            this.radioButtonFive.Size = new System.Drawing.Size(31, 17);
            this.radioButtonFive.TabIndex = 4;
            this.radioButtonFive.TabStop = true;
            this.radioButtonFive.Text = "5";
            this.radioButtonFive.UseVisualStyleBackColor = true;
            // 
            // radioButtonFour
            // 
            this.radioButtonFour.AutoSize = true;
            this.radioButtonFour.Location = new System.Drawing.Point(65, 18);
            this.radioButtonFour.Name = "radioButtonFour";
            this.radioButtonFour.Size = new System.Drawing.Size(31, 17);
            this.radioButtonFour.TabIndex = 3;
            this.radioButtonFour.TabStop = true;
            this.radioButtonFour.Text = "4";
            this.radioButtonFour.UseVisualStyleBackColor = true;
            // 
            // radioButtonThree
            // 
            this.radioButtonThree.AutoSize = true;
            this.radioButtonThree.Location = new System.Drawing.Point(16, 66);
            this.radioButtonThree.Name = "radioButtonThree";
            this.radioButtonThree.Size = new System.Drawing.Size(31, 17);
            this.radioButtonThree.TabIndex = 2;
            this.radioButtonThree.TabStop = true;
            this.radioButtonThree.Text = "3";
            this.radioButtonThree.UseVisualStyleBackColor = true;
            // 
            // radioButtonTwo
            // 
            this.radioButtonTwo.AutoSize = true;
            this.radioButtonTwo.Location = new System.Drawing.Point(16, 42);
            this.radioButtonTwo.Name = "radioButtonTwo";
            this.radioButtonTwo.Size = new System.Drawing.Size(31, 17);
            this.radioButtonTwo.TabIndex = 1;
            this.radioButtonTwo.TabStop = true;
            this.radioButtonTwo.Text = "2";
            this.radioButtonTwo.UseVisualStyleBackColor = true;
            // 
            // radioButtonOne
            // 
            this.radioButtonOne.AutoSize = true;
            this.radioButtonOne.Location = new System.Drawing.Point(16, 18);
            this.radioButtonOne.Name = "radioButtonOne";
            this.radioButtonOne.Size = new System.Drawing.Size(31, 17);
            this.radioButtonOne.TabIndex = 0;
            this.radioButtonOne.TabStop = true;
            this.radioButtonOne.Text = "1";
            this.radioButtonOne.UseVisualStyleBackColor = true;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(51, 171);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(0, 16);
            this.labelPrice.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(98, 213);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // CarRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CarRental";
            this.Text = "Car Rental";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonLuxury;
        private System.Windows.Forms.RadioButton radioButtonStandard;
        private System.Windows.Forms.RadioButton radioButtonCompact;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonSeven;
        private System.Windows.Forms.RadioButton radioButtonSix;
        private System.Windows.Forms.RadioButton radioButtonFive;
        private System.Windows.Forms.RadioButton radioButtonFour;
        private System.Windows.Forms.RadioButton radioButtonThree;
        private System.Windows.Forms.RadioButton radioButtonTwo;
        private System.Windows.Forms.RadioButton radioButtonOne;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button btnOk;
    }
}

