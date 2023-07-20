using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarDealer.cs
{
    public partial class mainForm : Form
    {
        Toyota toyota = new Toyota();
        BMW bmw = new BMW();
        Jaguar jaguar = new Jaguar();


        public mainForm()
        {
            InitializeComponent();
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (toyotaRadioButton.Checked)
            {
                toyota.ShowDialog();
            }
            else
                if (bmwRadioButton.Checked)
                {
                    bmw.ShowDialog();
                }
                else
                    if (jaguarRadioButton.Checked)
                    {
                        jaguar.ShowDialog();
                    }

        }

      


        
    }
}
