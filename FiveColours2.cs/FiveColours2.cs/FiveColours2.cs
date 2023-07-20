using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FiveColours2.cs
{
    public partial class FiveColours2 : Form
    {
        public FiveColours2()
        {
            InitializeComponent();
        }

        private void radioRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRed.Checked)
            {
                this.BackColor = Color.Red;
            }
        }

        private void radioBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBlue.Checked)
            {
                this.BackColor = Color.Blue;
            }
        }

        private void radioGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioGreen.Checked)
            {
                this.BackColor = Color.Green;
            }
        }

        private void radioOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOrange.Checked)
            {
                this.BackColor = Color.Orange;
            }
        }

        private void radioYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (radioYellow.Checked)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void FiveColours2_Load(object sender, EventArgs e)
        {
            
        }

    }
}
