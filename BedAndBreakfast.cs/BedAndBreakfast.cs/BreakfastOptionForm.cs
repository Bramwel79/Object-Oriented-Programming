﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BedAndBreakfast.cs
{
    public partial class BreakfastOptionForm : Form
    {
        private const double CONT_BREAKFAST_PRICE = 6.00;
        private const double FULL_BREAKFAST_PRICE = 9.95;
        private const double DELUXE_BREAKFAST_PRICE = 16.50;
        public BreakfastOptionForm()
        {
            InitializeComponent();
        }

        private void BreakfastOptionForm_Load(object sender, EventArgs e)
        {
            
            priceLabel.Text = "Price: " +
              CONT_BREAKFAST_PRICE.ToString("C");
        }

        private void contButton_CheckedChanged(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " +
             CONT_BREAKFAST_PRICE.ToString("C");
        }

        private void fullButton_CheckedChanged(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " +
              FULL_BREAKFAST_PRICE.ToString("C");
        }

        private void deluxeButton_CheckedChanged(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " +
              DELUXE_BREAKFAST_PRICE.ToString("C");
        }
    }
}
