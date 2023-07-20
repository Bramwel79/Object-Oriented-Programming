using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GenerateRandomNumbers.cs
{
    public partial class frmMain : Form
    {
        const int MAX_ELEMENT_ARRAY = 100;
        int[] arrayNumbers = new int[MAX_ELEMENT_ARRAY];
        string asterisks = "";
        public frmMain()
        {
            InitializeComponent();
        }
        public static void main()
        {
            frmMain main = new frmMain();
            Application.Run(main);
        }

       

        private void btnSortArray_Click(object sender, EventArgs e)
        {
            lstBoxNumbers.Items.Clear();
            //call SortArray method
            SortArray(arrayNumbers);
            for (int x = 0; x < MAX_ELEMENT_ARRAY; ++x)
            {
                lstBoxNumbers.Items.Add(arrayNumbers[x].ToString() + " " + asterisks.Substring(0, arrayNumbers[x]));
            }
            
            
        }

        private void SortArray(int[] array)
        {
            Array.Sort(array);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            FillAsterisksString();
            Random ran = new Random();
            //calculate random numbers
            for (int x = 0; x < MAX_ELEMENT_ARRAY; ++x)
            {
                arrayNumbers[x] = ran.Next(MAX_ELEMENT_ARRAY);
            }
            //display in list box
            for (int x = 0; x < MAX_ELEMENT_ARRAY; ++x)
            {
                lstBoxNumbers.Items.Add(arrayNumbers[x].ToString() + " " + asterisks .Substring (0,arrayNumbers [x]) );
                
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to Exit Application?", "Exit", MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (result == DialogResult.Yes )
            {
                Close();
            }
        }

        private void FillAsterisksString()
        {
            for (int i = 0; i < MAX_ELEMENT_ARRAY; ++i)
            {
                asterisks += "x";
            }
        }

       
    }
}
