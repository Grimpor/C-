namespace Aj.pp_online1
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)

        {
            string loguser = "Chalunton";
            string logpass = "1140";
            if ((password.Text == " " || username.Text == " ") || (password.Text == "" || username.Text == "") || (password.ForeColor == Color.Silver || username.ForeColor == Color.Silver))
            {
                MessageBox.Show("Pls input your username and password!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(username.Text != loguser || password.Text != logpass)
            {
                MessageBox.Show("Invalid Username or Password!!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                form2 f2 = new form2();
                f2.ShowDialog();
                this.Close();
            }
        }


        private void username_Click(object sender, EventArgs e)
        {
            if (username.ForeColor != Color.Black)
            {
                username.Text = "";
                username.ForeColor = Color.Black;
            }
        }

        private void password_Click(object sender, EventArgs e)
        {
            if (password.ForeColor != Color.Black)
            {
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if (username.ForeColor != Color.Black)
            {
                username.Text = "";
                username.ForeColor = Color.Black;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (password.ForeColor != Color.Black)
            {
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }

       
    }
}
