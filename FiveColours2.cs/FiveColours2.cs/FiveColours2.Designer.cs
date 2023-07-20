namespace FiveColours2.cs
{
    partial class FiveColours2
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
            this.radioRed = new System.Windows.Forms.RadioButton();
            this.radioBlue = new System.Windows.Forms.RadioButton();
            this.radioGreen = new System.Windows.Forms.RadioButton();
            this.radioOrange = new System.Windows.Forms.RadioButton();
            this.radioYellow = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioRed
            // 
            this.radioRed.AutoSize = true;
            this.radioRed.Location = new System.Drawing.Point(42, 30);
            this.radioRed.Name = "radioRed";
            this.radioRed.Size = new System.Drawing.Size(45, 17);
            this.radioRed.TabIndex = 0;
            this.radioRed.TabStop = true;
            this.radioRed.Text = "Red";
            this.radioRed.UseVisualStyleBackColor = true;
            this.radioRed.CheckedChanged += new System.EventHandler(this.radioRed_CheckedChanged);
            // 
            // radioBlue
            // 
            this.radioBlue.AutoSize = true;
            this.radioBlue.Location = new System.Drawing.Point(42, 69);
            this.radioBlue.Name = "radioBlue";
            this.radioBlue.Size = new System.Drawing.Size(46, 17);
            this.radioBlue.TabIndex = 1;
            this.radioBlue.TabStop = true;
            this.radioBlue.Text = "Blue";
            this.radioBlue.UseVisualStyleBackColor = true;
            this.radioBlue.CheckedChanged += new System.EventHandler(this.radioBlue_CheckedChanged);
            // 
            // radioGreen
            // 
            this.radioGreen.AutoSize = true;
            this.radioGreen.Location = new System.Drawing.Point(42, 108);
            this.radioGreen.Name = "radioGreen";
            this.radioGreen.Size = new System.Drawing.Size(54, 17);
            this.radioGreen.TabIndex = 2;
            this.radioGreen.TabStop = true;
            this.radioGreen.Text = "Green";
            this.radioGreen.UseVisualStyleBackColor = true;
            this.radioGreen.CheckedChanged += new System.EventHandler(this.radioGreen_CheckedChanged);
            // 
            // radioOrange
            // 
            this.radioOrange.AutoSize = true;
            this.radioOrange.Location = new System.Drawing.Point(42, 147);
            this.radioOrange.Name = "radioOrange";
            this.radioOrange.Size = new System.Drawing.Size(60, 17);
            this.radioOrange.TabIndex = 3;
            this.radioOrange.TabStop = true;
            this.radioOrange.Text = "Orange";
            this.radioOrange.UseVisualStyleBackColor = true;
            this.radioOrange.CheckedChanged += new System.EventHandler(this.radioOrange_CheckedChanged);
            // 
            // radioYellow
            // 
            this.radioYellow.AutoSize = true;
            this.radioYellow.Location = new System.Drawing.Point(42, 186);
            this.radioYellow.Name = "radioYellow";
            this.radioYellow.Size = new System.Drawing.Size(56, 17);
            this.radioYellow.TabIndex = 4;
            this.radioYellow.TabStop = true;
            this.radioYellow.Text = "Yellow";
            this.radioYellow.UseVisualStyleBackColor = true;
            this.radioYellow.CheckedChanged += new System.EventHandler(this.radioYellow_CheckedChanged);
            // 
            // FiveColours2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.radioYellow);
            this.Controls.Add(this.radioOrange);
            this.Controls.Add(this.radioGreen);
            this.Controls.Add(this.radioBlue);
            this.Controls.Add(this.radioRed);
            this.Name = "FiveColours2";
            this.Text = "Five Colours 2";
            this.Load += new System.EventHandler(this.FiveColours2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioRed;
        private System.Windows.Forms.RadioButton radioBlue;
        private System.Windows.Forms.RadioButton radioGreen;
        private System.Windows.Forms.RadioButton radioOrange;
        private System.Windows.Forms.RadioButton radioYellow;
    }
}

