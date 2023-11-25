using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        float result = 0, x = 0, y = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void sum_Click(object sender, EventArgs e)
        {
            minus.BackColor = DefaultBackColor;
            multiply.BackColor = DefaultBackColor;
            divide.BackColor = DefaultBackColor;
            sum.BackColor = Color.Gray;
        }

        public void minus_Click(object sender, EventArgs e)
        {
            sum.BackColor = DefaultBackColor;
            multiply.BackColor = DefaultBackColor;
            divide.BackColor = DefaultBackColor;
            minus.BackColor = Color.Gray;
        }

        public void multiply_Click(object sender, EventArgs e)
        {
            sum.BackColor = DefaultBackColor;
            minus.BackColor = DefaultBackColor;
            divide.BackColor = DefaultBackColor;
            multiply.BackColor = Color.Gray;

        }

        public void divide_Click(object sender, EventArgs e)
        {
            sum.BackColor = DefaultBackColor;
            minus.BackColor = DefaultBackColor;
            multiply.BackColor = DefaultBackColor;
            divide.BackColor = Color.Gray;
        }

        private void Show_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(X.Text);
            y = Convert.ToInt32(Y.Text);
            if (divide.BackColor == Color.Gray)
            {
                result = x / y;
                Calculate.Text = result.ToString();
                MessageBox.Show("You Choose Divide!!" + "\n" + x + " / " + y + " = " + result, "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if(multiply.BackColor == Color.Gray)
            {
                result = x * y;
                Calculate.Text = result.ToString();
                MessageBox.Show("You Choose Multiply!!" + "\n" + x + " * " + y + " = " + result, "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if(minus.BackColor == Color.Gray)
            {
                result = x - y;
                Calculate.Text = result.ToString();
                MessageBox.Show("You Choose Minus!!" + "\n" + x + " - " + y + " = " + result, "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if(sum.BackColor == Color.Gray)
            {
                result = x + y;
                Calculate.Text = result.ToString();
                MessageBox.Show("You Choose Sum!!" + "\n" + x + " + " + y + " = " + result, "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please choose some method", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(X.Text);
            y = Convert.ToInt32(Y.Text);
            if (divide.BackColor == Color.Gray)
            {
                result = x / y;
                Calculate.Text = result.ToString();
            }
            else if (multiply.BackColor == Color.Gray)
            {
                result = x * y;
                Calculate.Text = result.ToString();
            }
            else if (minus.BackColor == Color.Gray)
            {

                result = x - y;
                Calculate.Text = result.ToString();
            }
            else if (sum.BackColor == Color.Gray)
            {
                result = x + y;
                Calculate.Text = result.ToString();
            }
            else
            {
                result = 0;
                Calculate.Text = "Choose a method!!";
            }
        }


        private void Clear_Click(object sender, EventArgs e)
        {
            sum.BackColor = DefaultBackColor;
            minus.BackColor = DefaultBackColor;
            multiply.BackColor = DefaultBackColor;
            divide.BackColor = DefaultBackColor;
            X.Text = "0";
            Y.Text = "0";
            Calculate.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            X.Text = "0";
            Y.Text = "0";
            Calculate.Text = "0";
        }
    }
}
