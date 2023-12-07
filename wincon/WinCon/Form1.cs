namespace WinCon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Inch to Centimeter");
            listBox1.Items.Add("Centimeter to Inch");
            listBox1.Items.Add("Fahrenheit to Celsius");
            listBox1.Items.Add("Celsius to Fahrenheit");
            listBox1.Items.Add("Ounce to Gram");
            listBox1.Items.Add("Gram to Ounce");
            listBox1.Items.Add("Meter to Yard");
            listBox1.Items.Add("Yard to Meter");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float c = float.Parse(textBox1.Text);
            switch (listBox1.SelectedItem)
            {
                case "Inch to Centimeter":
                    textBox2.Text = (c * 2.45).ToString("F2");
                    label2.Text = "����";
                    label3.Text = "ૹ������";
                    break;
                case "Centimeter to Inch":
                    textBox2.Text = (c / 2.45).ToString("F2");
                    label2.Text = "ૹ������";
                    label3.Text = "����";
                    break;
                case "Fahrenheit to Celsius":
                    textBox2.Text = ((c - 32) * 5 / 9).ToString("F2");
                    label2.Text = "ͧ�ҿ��ù�ε�";
                    label3.Text = "ͧ��������";
                    break;
                case "Celsius to Fahrenheit":
                    textBox2.Text = ((c * 9 / 5) + 32).ToString("F2");
                    label2.Text = "ͧ��������";
                    label3.Text = "ͧ�ҿ��ù�ε�";
                    break;
                case "Ounce to Gram":
                    textBox2.Text = (c * 28.3495).ToString("F2");
                    label2.Text = "�͹��";
                    label3.Text = "����";
                    break;
                case "Gram to Ounce":
                    textBox2.Text = (c / 28.3495).ToString("F2");
                    label2.Text = "����";
                    label3.Text = "�͹��";
                    break;
                case "Meter to Yard":
                    textBox2.Text = (c * 1.094).ToString("F2");
                    label2.Text = "����";
                    label3.Text = "���";
                    break;
                case "Yard to Meter":
                    textBox2.Text = (c / 1.094).ToString("F2");
                    label2.Text = "���";
                    label3.Text = "����";
                    break;
                default:
                    MessageBox.Show("Pls select a method!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedItem)
            {
                case "Inch to Centimeter":
                    label2.Text = "����";
                    label3.Text = "ૹ������";
                    break;
                case "Centimeter to Inch":
                    label2.Text = "ૹ������";
                    label3.Text = "����";
                    break;
                case "Fahrenheit to Celsius":
                    label2.Text = "ͧ�ҿ��ù�ε�";
                    label3.Text = "ͧ��������";
                    break;
                case "Celsius to Fahrenheit":
                    label2.Text = "ͧ��������";
                    label3.Text = "ͧ�ҿ��ù�ε�";
                    break;
                case "Ounce to Gram":
                    label2.Text = "�͹��";
                    label3.Text = "����";
                    break;
                case "Gram to Ounce":
                    label2.Text = "����";
                    label3.Text = "�͹��";
                    break;
                case "Meter to Yard":
                    label2.Text = "����";
                    label3.Text = "���";
                    break;
                case "Yard to Meter":
                    label2.Text = "���";
                    label3.Text = "����";
                    break;
                default:
                    MessageBox.Show("Pls select a method!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
