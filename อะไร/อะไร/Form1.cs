using System.Globalization;

namespace อะไร
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbsong.Items.Add("เพลงลาวดวงเดือน");
            cmbsong.Items.Add("เพลง เพล๊ง เพล๊ง");
            cmbsong.Items.Add("เพลงตุเลง ตุเลง");
            cmbsong.Items.Add("เพลงพม่าดวงดาว");
            cmbsong.Items.Add("เพลงจี่หอย");

            listsong.Items.Add("ของแขก");
            listsong.Items.Add("สัปเหร่อ");
            listsong.Items.Add("ธี่หยด");
            listsong.Items.Add("ตับอ่อนเธอนั้น ฉันขอเถอะนะ");
            listsong.Items.Add("คำโกหกในเดือนเมษา");

            for (int i = 1; i <= 20; i++)
            {
                listFOR.Items.Add("เพลงที่ " + i);
            }

            int j = 10;
            while (j >= 1)
            {
                listWhile.Items.Add("รายการที่ # " + j);
                j--;
            }
            int k = 5;
            do
            {
                listDowhile.Items.Add("เลขที่ " + k);
                k += 5;
            } while (k <= 40);

        }

        private void cmbsong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsong.Text = cmbsong.SelectedItem.ToString();
        }

        private void listsong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmovie.Text = listsong.SelectedItem.ToString();
        }
    }
}
