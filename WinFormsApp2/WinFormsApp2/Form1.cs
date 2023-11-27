namespace WinFormsApp2
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
            divide.BackColor = DefaultBackColor;
            multiply.BackColor = DefaultBackColor;
            minus.BackColor = DefaultBackColor;
            sum.BackColor = Color.Gray;
        }

        public void minus_Click(object sender, EventArgs e)
        {
            divide.BackColor = DefaultBackColor;
            multiply.BackColor = DefaultBackColor;
            sum.BackColor = DefaultBackColor;
            minus.BackColor = Color.Gray;
        }

        public void multiply_Click(object sender, EventArgs e)
        {
            divide.BackColor = DefaultBackColor;
            sum.BackColor = DefaultBackColor;
            minus.BackColor = DefaultBackColor;
            multiply.BackColor = Color.Gray;
        }

        public void divide_Click(object sender, EventArgs e)
        {
            sum.BackColor = DefaultBackColor;
            multiply.BackColor = DefaultBackColor;
            minus.BackColor = DefaultBackColor;
            divide.BackColor = Color.Gray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sum.BackColor = DefaultBackColor;
            multiply.BackColor = DefaultBackColor;
            minus.BackColor = DefaultBackColor;
            divide.BackColor = DefaultBackColor;
            X.Text = "";
            Y.Text = "";
            Calculate.Text = "";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            sum.BackColor = DefaultBackColor;
            multiply.BackColor = DefaultBackColor;
            minus.BackColor = DefaultBackColor;
            divide.BackColor = DefaultBackColor;
            X.Text = "";
            Y.Text = "";
            Calculate.Text = "";

        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (X.Text == "" || Y.Text == "")
            {
                MessageBox.Show("Pls input a number!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                x = Convert.ToInt32(X.Text);
                y = Convert.ToInt32(Y.Text);
                if (divide.BackColor == Color.Gray)
                {
                    if (y == 0)
                    {
                        MessageBox.Show("Can't divide by 0\nPlease try again.");
                    }
                    else
                    {
                        result = x / y;
                        Calculate.Text = result.ToString();
                    }
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
        }

        private void Show_Click(object sender, EventArgs e)
        {
            
            if (X.Text == "" || Y.Text == "")
            {
                MessageBox.Show("Pls input a number!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                x = Convert.ToInt32(X.Text);
                y = Convert.ToInt32(Y.Text);
                if (divide.BackColor == Color.Gray)
                {
                    if (y == 0)
                    {
                        MessageBox.Show("Can't divide by 0\nPlease try again.");
                    }
                    else
                    {
                        result = x / y;
                        Calculate.Text = result.ToString();
                        MessageBox.Show("You Choose Divide!!" + "\n" + x + " / " + y + " = " + result, "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
                else if (multiply.BackColor == Color.Gray)
                {
                    result = x * y;
                    Calculate.Text = result.ToString();
                    MessageBox.Show("You Choose Multiply!!" + "\n" + x + " * " + y + " = " + result, "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else if (minus.BackColor == Color.Gray)
                {
                    result = x - y;
                    Calculate.Text = result.ToString();
                    MessageBox.Show("You Choose Minus!!" + "\n" + x + " - " + y + " = " + result, "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else if (sum.BackColor == Color.Gray)
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
        }
    }
}