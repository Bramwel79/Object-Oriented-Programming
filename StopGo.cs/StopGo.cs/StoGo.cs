using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StopGo.cs
{
    public partial class StopGo : Form
    {
        public StopGo()
        {
            InitializeComponent();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
    }
}
