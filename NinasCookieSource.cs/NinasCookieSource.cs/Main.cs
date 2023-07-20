using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NinasCookieSource.cs
{
    public partial class Main : Form
    {
        
       

        private const double GINGER_COOKIE_PRICE_PER_DOZEN = 45.65;
        private const double CHOCOLATE_COOKIE_PRICE_PER_DOZEN = 56.55;
        private const double VANILLA_COOKIE_PRICE_PER_DOZEN = 77.55;

        private const double HALF_DOZEN = 0.50;
        private const double ONE_DOZEN = 1.00;

        private const int SHIPPING_DAYS = 3;

        double cookiePricePerDozen = 0;
        double quantity = 0;
        double totalPrice = 0;

        string deliveryDate;

        public Main()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
                      
            //determine ginger type selected
            if (gingerRadioButton.Checked)
            {
                cookiePricePerDozen = GINGER_COOKIE_PRICE_PER_DOZEN; 
            }
            else
                if (chocolateRadioButton.Checked)
                {
                    cookiePricePerDozen = CHOCOLATE_COOKIE_PRICE_PER_DOZEN;
                }
                else
                    if (vanillaRadioButton.Checked)
                    {
                        cookiePricePerDozen = VANILLA_COOKIE_PRICE_PER_DOZEN;
                    }
            //determine quantity  selected
            if (choiceListBox.GetSelected(0))
            {
                quantity = HALF_DOZEN;
            }
            else
                if (choiceListBox.GetSelected(1))
                {
                    quantity = ONE_DOZEN;
                }
                else
                    if (choiceListBox.GetSelected(2))
                    {
                        quantity = ONE_DOZEN * 2;
                    }
                    else
                        if (choiceListBox.GetSelected(3))
                        {
                            quantity = ONE_DOZEN * 3;
                        }

            totalPrice = cookiePricePerDozen * quantity;
            lblPrice.Text = "The total price is " + totalPrice.ToString("c") + " and the delivery date is " + deliveryDate ;
            lblPrice.BackColor = Color.LightGreen;
            
            
        }

        private void orderDateCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
             deliveryDate = orderDateCalendar.SelectionStart.AddDays(SHIPPING_DAYS).ToLongDateString();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            orderDateCalendar.MinDate = DateTime.Today;
        }

     }
}
