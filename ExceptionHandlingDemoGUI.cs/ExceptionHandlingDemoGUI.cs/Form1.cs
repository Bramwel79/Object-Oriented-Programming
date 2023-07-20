using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExceptionHandlingDemoGUI.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int input;
            try
            {
                input = Convert.ToInt32(txtEntry.Text);
                lblMessage.Text = "Input string  in correct format.";
                lblMessage.BackColor = Color.LightGreen ;
                txtEntry.Text = "";
            }
            catch (FormatException f)
            {
                lblMessage.Text = f.Message;
                lblMessage.BackColor = Color.LightPink;
                txtEntry.Text = "";
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
