using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IdealWeight.cs
{
    public partial class frmMain : Form
    {
        const double MINHEIGHT = 36;
        const double MAXHEIGHT = 96;
        public frmMain()
        {
            InitializeComponent();
        }

        public static void Main()
        {
          frmMain main = new frmMain() ;
          Application.Run (main );

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            int startHeight;
            int endHeight;
            bool flag;
            double[,] idealWeights;
            double male;
            double female;
            int i ;
            int j;
            //string results;
            //get input from client
            flag = int.TryParse(txtStartingHeight.Text, out startHeight);
            if (flag == false)
            {
                MessageBox.Show("Error in input.");
                txtStartingHeight.Clear();
                txtStartingHeight.Focus();
                return;
            }
            flag = int.TryParse(txtEndingHeight.Text, out endHeight);
            if (flag == false)
            {
                MessageBox.Show("Error in input.");
                txtEndingHeight.Clear();
                txtEndingHeight.Focus();
                return;
            }
            //validate input
            if (startHeight < MINHEIGHT || startHeight > MAXHEIGHT ||
                endHeight < MINHEIGHT || endHeight > MAXHEIGHT)
            {
                MessageBox.Show("Minimum height is " + MINHEIGHT + " and " +
                                "Maximum height is " + MAXHEIGHT);
                txtStartingHeight.Focus();
                txtEndingHeight.Focus();
                return;
            }

            int rows = (int)((endHeight - startHeight) + 1);
            idealWeights = new double [rows,3];

            female = 3.5 * startHeight - 108;
            male = 4.0 * startHeight - 128;

            for ( i = (int)startHeight, j = 0; i <= (int)endHeight; ++i, ++j)
            {
                idealWeights[j,0] = i;
                idealWeights[j,1] = (female += 3.5);
                idealWeights[j,2] = (male += 4.0);

            }
            //display results
            for (i = (int)startHeight, j = 0; i <= (int)endHeight; ++i, ++j)
            {
                //results = string.Format("{0,5}{1,15}{2,15}",i,idealWeights [0,j],idealWeights [1,j]);
               ListViewItem  one = new ListViewItem (idealWeights [j,0].ToString ());
              // one.SubItems.Add(i.ToString());
                one.SubItems .Add(idealWeights[j,1].ToString ());
                one.SubItems.Add(idealWeights[j, 2].ToString());
                lstViewResults.Items.Add(one);

              // one.SubItems.Add(results);
               //lstViewResults.Items.Add(one);



            }


        }
    }
}
