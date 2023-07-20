using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FiveColours.cs
{
    public partial class FiveColours : Form
    {
        public FiveColours()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
    }
}
