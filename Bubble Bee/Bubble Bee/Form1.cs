using System.Diagnostics.Eventing.Reader;

namespace Bubble_Bee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string name = "Nantiva Boonpa";
            string pass = "1146";

            if (textName.Text == name || textPassword.Text == pass)
            {
                MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Form2 BuBeeCafe = new Form2();
                this.Hide();
                BuBeeCafe.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textName_Enter(object sender, EventArgs e)
        {
            if (textName.ForeColor != Color.Black)
            {
                textName.Text = "";
                textName.ForeColor = Color.Black;
            }
        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            if (textPassword.ForeColor != Color.Black)
            {
                textPassword.Text = "";
                textPassword.ForeColor = Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
