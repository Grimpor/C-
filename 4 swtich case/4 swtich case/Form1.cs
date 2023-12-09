namespace _4_swtich_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            change.Items.Add("Inch to Centimeter");
            change.Items.Add("Centimeter to Inch");
            change.Items.Add("Fahrenheit to Celsius");
            change.Items.Add("Celsius to Fahrenheit");
            change.Items.Add("Ounce to Gram");
            change.Items.Add("Gram to Ounce");
            change.Items.Add("Meter to Yard");
            change.Items.Add("Yard to Meter");

        }

        private void X_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 58) && (e.KeyChar != 8) && (e.KeyChar != 46) && (e.KeyChar != 45))
            {
                e.Handled = true;
            }
        }

        private void X_TextChanged(object sender, EventArgs e)
        {
            if (X.Text != "")
            {
                ok.Enabled = true;
            }
            else
            {
                ok.Enabled = false;
            }

        }

        private void ok_Click(object sender, EventArgs e)
        {
            float x = float.Parse(X.Text);
            switch (change.SelectedItem)
            {
                case "Inch to Centimeter":
                    Y.Text = (x * 2.54).ToString("F2");
                    From.Text = "นิ้ว";
                    To.Text = "เซนติเมตร";
                    break;
                case "Centimeter to Inch":
                    Y.Text = (x / 2.54).ToString("F2");
                    From.Text = "เซนติเมตร";
                    To.Text = "นิ้ว";
                    break;
                case "Fahrenheit to Celsius":
                    Y.Text = ((x - 32) * 5 / 9).ToString("F2");
                    From.Text = "องศาฟาเรนไฮต์";
                    To.Text = "องศาเซลเซียส";
                    break;
                case "Celsius to Fahrenheit":
                    Y.Text = ((x * 9 / 5) + 32).ToString("F2");
                    From.Text = "องศาเซลเซียส";
                    To.Text = "องศาฟาเรนไฮต์";
                    break;
                case "Ounce to Gram":
                    Y.Text = (x * 28.3495).ToString("F2");
                    From.Text = "ออนซ์";
                    To.Text = "กรัม";
                    break;
                case "Gram to Ounce":
                    Y.Text = (x / 28.3495).ToString("F2");
                    From.Text = "กรัม";
                    To.Text = "ออนซ์";
                    break;
                case "Meter to Yard":
                    Y.Text = (x * 1.09361).ToString("F2");
                    From.Text = "เมตร";
                    To.Text = "หลา";
                    break;
                case "Yard to Meter":
                    Y.Text = (x / 1.09361).ToString("F2");
                    From.Text = "หลา";
                    To.Text = "เมตร";
                    break;
                default:
                    break;

            }
        }

        private void Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void change_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (X.Text != "")
            {
                float x = float.Parse(X.Text);
                switch (change.SelectedItem)
                {
                    case "Inch to Centimeter":
                        Y.Text = (x * 2.54).ToString("F2");
                        From.Text = "นิ้ว";
                        To.Text = "เซนติเมตร";
                        break;
                    case "Centimeter to Inch":
                        Y.Text = (x / 2.54).ToString("F2");
                        From.Text = "เซนติเมตร";
                        To.Text = "นิ้ว";
                        break;
                    case "Fahrenheit to Celsius":
                        Y.Text = ((x - 32) * 5 / 9).ToString("F2");
                        From.Text = "องศาฟาเรนไฮต์";
                        To.Text = "องศาเซลเซียส";
                        break;
                    case "Celsius to Fahrenheit":
                        Y.Text = ((x * 9 / 5) + 32).ToString("F2");
                        From.Text = "องศาเซลเซียส";
                        To.Text = "องศาฟาเรนไฮต์";
                        break;
                    case "Ounce to Gram":
                        Y.Text = (x * 28.3495).ToString("F2");
                        From.Text = "ออนซ์";
                        To.Text = "กรัม";
                        break;
                    case "Gram to Ounce":
                        Y.Text = (x / 28.3495).ToString("F2");
                        From.Text = "กรัม";
                        To.Text = "ออนซ์";
                        break;
                    case "Meter to Yard":
                        Y.Text = (x * 1.09361).ToString("F2");
                        From.Text = "เมตร";
                        To.Text = "หลา";
                        break;
                    case "Yard to Meter":
                        Y.Text = (x / 1.09361).ToString("F2");
                        From.Text = "หลา";
                        To.Text = "เมตร";
                        break;
                    default:
                        break;

                }
            }
            else
            {
                switch (change.SelectedItem)
                {
                    case "Inch to Centimeter":
                        From.Text = "นิ้ว";
                        To.Text = "เซนติเมตร";
                        break;
                    case "Centimeter to Inch":
                        From.Text = "เซนติเมตร";
                        To.Text = "นิ้ว";
                        break;
                    case "Fahrenheit to Celsius":
                        From.Text = "องศาฟาเรนไฮต์";
                        To.Text = "องศาเซลเซียส";
                        break;
                    case "Celsius to Fahrenheit":
                        From.Text = "องศาเซลเซียส";
                        To.Text = "องศาฟาเรนไฮต์";
                        break;
                    case "Ounce to Gram":
                        From.Text = "ออนซ์";
                        To.Text = "กรัม";
                        break;
                    case "Gram to Ounce":
                        From.Text = "กรัม";
                        To.Text = "ออนซ์";
                        break;
                    case "Meter to Yard":
                        From.Text = "เมตร";
                        To.Text = "หลา";
                        break;
                    case "Yard to Meter":
                        From.Text = "หลา";
                        To.Text = "เมตร";
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
