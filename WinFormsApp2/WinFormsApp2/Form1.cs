namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        float result = 0, x = 0, y = 0;
        bool xbool = false;
        bool ybool = false;
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

            if (float.TryParse(X.Text, out x) && float.TryParse(Y.Text, out y))
            {
                x = float.Parse(X.Text);
                y = float.Parse(Y.Text);
                if (divide.BackColor == Color.Gray)
                {
                    if (y == 0)
                    {
                        MessageBox.Show("Can't divide by 0\nPlease try again.");
                        Calculate.Text = "Error";
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
                    Calculate.Text = result.ToString();                }
                else
                {
                    MessageBox.Show("Please choose some method", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Calculate.Text = "Error";
                MessageBox.Show("Pls input a number!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {

            if (float.TryParse(X.Text, out x) && float.TryParse(Y.Text, out y))
            {
                x = float.Parse(X.Text);
                y = float.Parse(Y.Text);
                if (divide.BackColor == Color.Gray)
                {
                    if (y == 0)
                    {
                        MessageBox.Show("Can't divide by 0\nPlease try again.");
                        Calculate.Text = "Error";
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
            else
            {
                Calculate.Text = "Error";
                MessageBox.Show("Pls input a number!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void X_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 45) || (e.KeyChar == 46))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 45) || (e.KeyChar == 46))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void X_TextChanged(object sender, EventArgs e)
        {
            if (X.Text != "")
            {
                xbool = true;
                Clear.Enabled = true;
            }
            else
            {
                xbool = false;
                Clear.Enabled = false;
            }
            if (xbool == true && ybool == true)
            {
                OK.Enabled = true;
                Show.Enabled = true;
            }
            else
            {
                OK.Enabled = false;
                Show.Enabled = false;
            }
        }

        private void Y_TextChanged(object sender, EventArgs e)
        {
            if (Y.Text != "")
            {
                ybool = true;
                Clear.Enabled = true;
            }
            else
            {
                ybool = false;
                Clear.Enabled = false;
            }
            if (xbool == true && ybool == true)
            {
                OK.Enabled = true;
                Show.Enabled = true;
            }
            else
            {
                OK.Enabled = false;
                Show.Enabled = false;
            }
        }

        private void Calculate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}