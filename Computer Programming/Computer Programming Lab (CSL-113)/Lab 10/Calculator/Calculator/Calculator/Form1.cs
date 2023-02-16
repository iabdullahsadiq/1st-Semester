using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void add(int num1, int num2)
        {
            int add = num1 + num2;
            MessageBox.Show("The sum is " + add);
        }

        static void Sub(int num1, int num2)
        {
            int Sub = num1 - num2;
            MessageBox.Show("The Difference is " + Sub);
        }

        static void Mul(int num1, int num2)
        {
            int Mul = num1 * num2;
            MessageBox.Show("The Product is " + Mul);
        }

        static void Div(int num1, int num2)
        {
            int Div = num1 / num2;
            MessageBox.Show("The Answer is " + Div);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtnum1.Text);
            int num2 = Convert.ToInt32(txtnum2.Text);
            if (rbsum.Checked == true)
            {
                add(num1, num2);
            }
            else if (rbsub.Checked == true)
            {
                Sub(num1, num2);
            }
            else if (rbmultiply.Checked==true)
            {
                Mul(num1, num2);
            }
            else if (rbdivide.Checked==true)
            {
                Div(num1, num2);
            }
            else
            {
                MessageBox.Show("You have not Selected any option!");
            }

        }
    }
}
