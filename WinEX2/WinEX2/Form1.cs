namespace WinEX2
{
    public partial class Grim : Form
    {
        public Grim()
        {
            InitializeComponent();
        }

        private void Hello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello!! " + name.Text, "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "")
            {
                MessageBox.Show("Pls input a number!!", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int num1, num2, result;

                num1 = int.Parse(txt1.Text);
                num2 = int.Parse(txt2.Text);
                result = num1 - num2;
                txtresult.Text = result.ToString();
            }



            /***********แปลงค่าโดยใช้ Convert**************
            num1 = Convert.ToInt16(txt1.Text);
            num2 = Convert.ToInt16(txt2.Text);
            result = num1 + num2;
            txtresult.Text = result.ToString();
            *******************************************/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "")
            {
                MessageBox.Show("Pls input a number!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtresult.Text = Convert.ToString(Convert.ToInt32(txt1.Text) + Convert.ToInt32(txt2.Text));
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txtresult.Text = "";
            txt1.Clear();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "")
            {
                MessageBox.Show("Pls input a number!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txt2.Text == "0")
                {
                    MessageBox.Show("Can't divide by 0\nPlease try again.");
                }
                else
                {
                    int num1, num2, result;

                    num1 = int.Parse(txt1.Text);
                    num2 = int.Parse(txt2.Text);
                    result = num1 / num2;
                    txtresult.Text = result.ToString();
                }
            }
        }
    }
}