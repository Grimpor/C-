namespace Aj.pp_online1
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if((username.Text == " " ||  password.Text == " ")||(username.Text == "" || password.Text == "")||(username.ForeColor == Color.Silver || password.ForeColor == Color.Silver))
            {
                MessageBox.Show("Pls input your username and password!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Close();
            }
        }


        private void username_Enter(object sender, EventArgs e)
        {
            if(username.ForeColor != Color.Black)
            {
                username.Text = "";
                username.ForeColor = Color.Black;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.ForeColor != Color.Black)
            {
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }

    }
}
