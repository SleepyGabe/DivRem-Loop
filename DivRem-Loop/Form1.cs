using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTFI1B_Parinas_DivRemLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Goal: Get the quotient and remainder from a given divisor and dividend minus the use of modulo and 
            //stuff like that-
            //1.) Declare variables for Divisor, Dividend, Quotient, and Remainder
            int Div1, Div2, RemNum, QuoNum = 0;

            //2A.) Check for any blank/invalid entries
            //2B.) Declare variables for both input boxes
            bool Boxxy, BoxxyJr;

            Boxxy = int.TryParse(Num1.Text, out Div1);

            if (Boxxy == false)
            {
                MessageBox.Show("Please enter a VALID NUMBER for the Dividend");
                Num1.Clear();
                Num1.Select();
                return;
            }
            BoxxyJr = int.TryParse(Num2.Text, out Div2);

            if (BoxxyJr == false)
            {
                MessageBox.Show("Please enter a VALID NUMBER for the Divisor");
                Num2.Clear();
                Num2.Select();
                return;
            }
            //3.) Retrieve inputs from user
            Div1 = int.Parse(Num1.Text);
            Div2 = int.Parse(Num2.Text);
            //4.) Divide 
            if (Div1 > Div2)
            {
                while (Div1 >= Div2)
                {
                    Div1 = Div1 - Div2;
                    QuoNum++;
                }
                RemNum = Div1;
                TxtQuot.Text = QuoNum.ToString();
                TxtRem.Text = RemNum.ToString();
            }
            else
            {
                MessageBox.Show("Enter a VALID input");
            }
        }
    }
}
