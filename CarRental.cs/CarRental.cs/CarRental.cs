using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarRental.cs
{
    public partial class CarRental : Form
    {
        private const double COMPACT_PER_DAY_PRICE = 19.95;
        private const double STANDARD_PER_DAY_PRICE = 24.95;
        private const double LUXURY_PER_DAY_PRICE = 39.00;
        public CarRental()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double carPrice = 0;
            int daysRented = 0;
            double rentalFee = 0;

            if (radioButtonCompact.Checked)
            {
                carPrice = COMPACT_PER_DAY_PRICE;
            }
            else
                if (radioButtonStandard.Checked)
                {
                    carPrice = STANDARD_PER_DAY_PRICE;
                }
                else
                    if (radioButtonLuxury.Checked)
                    {
                        carPrice = LUXURY_PER_DAY_PRICE;
                    }
                    else
                        carPrice = 0;


            if (radioButtonOne.Checked)
            {
                daysRented = 1;
            }
            else
                if (radioButtonTwo.Checked)
                {
                    daysRented = 2;
                }
                else
                    if (radioButtonThree.Checked)
                    {
                        daysRented = 3;
                    }
                    else
                        if (radioButtonFour.Checked)
                        {
                            daysRented = 4;
                        }
                        else
                            if (radioButtonFive.Checked)
                            {
                                daysRented = 5;
                            }
                            else
                                if (radioButtonSix.Checked)
                                {
                                    daysRented = 6;
                                }
                                else
                                    if (radioButtonSeven.Checked)
                                    {
                                        daysRented = 7;
                                    }
                                    else
                                        daysRented = 0;
                                    

            rentalFee = carPrice * daysRented;
            labelPrice.Text = "Total cost to rent Car is " + rentalFee . ToString ("c");
            labelPrice.BackColor = Color.LightGreen;

        }
    }
}
