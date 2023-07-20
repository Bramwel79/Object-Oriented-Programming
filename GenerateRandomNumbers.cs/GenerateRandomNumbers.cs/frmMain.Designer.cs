namespace GenerateRandomNumbers.cs
{
    partial class frmMain
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
            this.lstBoxNumbers = new System.Windows.Forms.ListBox();
            this.btnSortArray = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxNumbers
            // 
            this.lstBoxNumbers.FormattingEnabled = true;
            this.lstBoxNumbers.Location = new System.Drawing.Point(12, 31);
            this.lstBoxNumbers.Name = "lstBoxNumbers";
            this.lstBoxNumbers.Size = new System.Drawing.Size(599, 134);
            this.lstBoxNumbers.TabIndex = 0;
            // 
            // btnSortArray
            // 
            this.btnSortArray.Location = new System.Drawing.Point(262, 182);
            this.btnSortArray.Name = "btnSortArray";
            this.btnSortArray.Size = new System.Drawing.Size(75, 43);
            this.btnSortArray.TabIndex = 1;
            this.btnSortArray.Text = "Sort Array";
            this.btnSortArray.UseVisualStyleBackColor = true;
            this.btnSortArray.Click += new System.EventHandler(this.btnSortArray_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(170, 182);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 43);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(354, 182);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 43);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Random Number between 0 and 99:";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(623, 262);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnSortArray);
            this.Controls.Add(this.lstBoxNumbers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Random Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxNumbers;
        private System.Windows.Forms.Button btnSortArray;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

