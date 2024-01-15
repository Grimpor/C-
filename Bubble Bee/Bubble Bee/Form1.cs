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
            if (textName.Text == " " || textPassword.Text == " ")
            {
                MessageBox.Show("Plase Input Username and Password", "Warnig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textName.Text == "" || textPassword.Text == "")
            {
                MessageBox.Show("Plase Input Username and Password", "Warnig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form2 form = new Form2();
                this.Hide();
                form.ShowDialog();
                this.Close();
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
    }
}
