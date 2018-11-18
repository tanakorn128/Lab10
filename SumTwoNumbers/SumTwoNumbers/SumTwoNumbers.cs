using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumTwoNumbers
{
    public partial class SumTwoNumbers : Form
    {
        public SumTwoNumbers()
        {
            InitializeComponent();
        }

        private void SumTwoNumbers_Load(object sender, EventArgs e)
        {
            //get input values and convert strings to doubles
           


        }

        private void secondNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void firstNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sumLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
           
                double number1, number2,sum;
                number1 = double.Parse(firstNumberLabel.Text);
            Console.WriteLine("{0}",number1);
               // number2 = double.Parse(secondNumberLabel.Text);

                //sum the two numbers
               // sum = number1 + number2;

                //display maximum value
              //  sumLabel.Text = number1.ToString();
            
        }
    }
}
