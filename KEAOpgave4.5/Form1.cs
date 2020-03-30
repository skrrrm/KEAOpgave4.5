using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEAOpgave4._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Clearing listbox' on click of button
            listBoxSquareRoot.Items.Clear();
            listBoxX.Items.Clear();
            listBoxX2.Items.Clear();
            listBoxX3.Items.Clear();

            // Variables
            double x = 1;
            int max = 0;
            double ans;
            double rndAns;

            // Try-catch for intergers
            try
            {
                max = Convert.ToInt32(textBoxX.Text); // converts to int
            }
            catch
            {
                MessageBox.Show("Numbers only!", "Error"); // errorbox
            }

            do // do while loop to run the first calculation in case max should have an input of one
            {
                listBoxX.Items.Add(x); // lists every number a calculation is done for.
                
                ans = (Math.Sqrt(x)); // calculation done for square root of x
                rndAns = Math.Round(ans, 2); // rounding x down to two decimals for the looks
                listBoxSquareRoot.Items.Add($"{rndAns}"); // finally the answer is printe for square root of x into rndAns that has been rounded
                
                listBoxX2.Items.Add(Math.Pow(x, 2.0)); // calculation and print of x to the power of two
                listBoxX3.Items.Add(Math.Pow(x, 3.0)); // calculation and print of x to the power of three

                x++; // x = x + 1
            } while (x <= max);
        }
    }
}
