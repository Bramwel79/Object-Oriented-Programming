using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurant.cs
{
    public partial class Restaurant : Form
    {
        private const double SIMPLE_LEMON_FRUIT_DIP_PRICE = 5.95;
        private const double CHIVE_GARLIC_BREAD_PRICE = 4.85;
        private const double BRUSCHETTA_WITH_PROSCIUTTO_PRICE = 6.50;
        private const double RICE_WITH_CHICKEN_STEW_PRICE = 12.45;
        private const double CHAPATI_WITH_DENGU_PRICE = 10.95;
        private const double UGALI_WITH_ROAST_BEEF_PRICE = 11.85;
        private const double YOGHURT_PRICE = 5.00;
        private const double VANILLA_ICE_CREAM_PRICE = 2.55;
        private const double CAKE_PRICE = 3.85;

        public Restaurant()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double appetizerPrice = 0;
            double entreePrice = 0;
            double dessertPrice = 0;
            double totalPrice = 0;

            // determine appetizer prices
            if (simpleLemonFruitDipAppetizer.Checked)
            {
                appetizerPrice = SIMPLE_LEMON_FRUIT_DIP_PRICE;
            }
            else
                if (chiveGarlicBreadAppetizer.Checked)
                {
                    appetizerPrice = CHIVE_GARLIC_BREAD_PRICE;

                }
                else
                    if (bruschettaWithProsciuttoAppetizer.Checked)
                    {
                        appetizerPrice = BRUSCHETTA_WITH_PROSCIUTTO_PRICE;
                    }
                    else
                        appetizerPrice = 0;

            // determine entree prices
            if (riceWithChickenStewEntree.Checked)
            {
                entreePrice = RICE_WITH_CHICKEN_STEW_PRICE;
            }
            else
                if (chapatiWithDenguEntree.Checked)
                {
                    entreePrice = CHAPATI_WITH_DENGU_PRICE;
                }
                else
                    if (ugaliWithRoastBeefEntree.Checked)
                    {
                        entreePrice = UGALI_WITH_ROAST_BEEF_PRICE;
                    }
                    else
                        entreePrice = 0;

            // determine dessert prices
            if (yoghurtRadioButton.Checked)
            {
                dessertPrice = YOGHURT_PRICE;
            }
            else
                if (vanillaIceCreamRadioButton.Checked)
                {
                    dessertPrice = VANILLA_ICE_CREAM_PRICE;
                }
                else
                    if (cakeRadioButton.Checked)
                    {
                        dessertPrice = CAKE_PRICE;
                    }

            //determine total price of meal
            totalPrice = appetizerPrice + entreePrice + dessertPrice;
            labelPrice.Text = "The meal cost is " + totalPrice.ToString("c");
            labelPrice.BackColor = Color.LightGreen;
        }
    }
}
