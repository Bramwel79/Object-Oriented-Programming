using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Video.cs
{
    public partial class Video : Form
    {
        private const double PRICE_PER_VIDEO = 2.50;
        public Video()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int count;
            double totalPrice;
            count = movieChoiceListBox.SelectedItems.Count;
            totalPrice = count * PRICE_PER_VIDEO;
            priceLabel.Text = "Total Price is " + totalPrice.ToString ("c");

        }
    }
}
