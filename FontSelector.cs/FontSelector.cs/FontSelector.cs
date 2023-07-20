using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FontSelector.cs
{
    public partial class FontSelector : Form
    {
        
        public FontSelector()
        {
            InitializeComponent();
        }

        private void FontSelector_Load(object sender, EventArgs e)
        {
            this.fontNamelistBox.SetSelected(0, true);
            this.fontSizelistBox.SetSelected(0, true);
            

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string fontName;
            float fontSize;

            if (fontNamelistBox.GetSelected(0))
            {
                fontName = "Sans serif";
            }
            else
                if (fontNamelistBox.GetSelected(1))
                {
                    fontName = "Courier";
                }
                else
                    if (fontNamelistBox.GetSelected(2))
                    {
                        fontName = "Papyrus";
                    }
                    else
                        fontName = "Times Roman";

            if (fontSizelistBox.GetSelected(0))
            {
                fontSize = 5;
            }
            else
                if (fontSizelistBox.GetSelected(1))
                {
                    fontSize = 8;
                }
                else
                    if (fontSizelistBox.GetSelected(2))
                    {
                        fontSize = 10;
                    }
                    else
                        fontSize = 12;
            Font newFont = new Font(fontName, fontSize);
            lblHello.Font = newFont;
                        


            
        }
    }
}
