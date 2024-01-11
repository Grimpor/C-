using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aj.pp_online1
{
    public partial class Form2 : Form
    {
        int basketnum = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            if (check1.Checked == true)
            {
                basketnum++;
            }
            else
            {
                basketnum--;
            }
            Basket.Text = basketnum.ToString();

        }

        private void check2_CheckedChanged(object sender, EventArgs e)
        {
            if (check2.Checked == true)
            {
                basketnum++;
            }
            else
            {
                basketnum--;
            }
            Basket.Text = basketnum.ToString();
        }

        private void check3_CheckedChanged(object sender, EventArgs e)
        {
            if (check3.Checked == true)
            {
                basketnum++;
            }
            else
            {
                basketnum--;
            }
            Basket.Text = basketnum.ToString();
        }

        private void check4_CheckedChanged(object sender, EventArgs e)
        {
            if (check4.Checked == true)
            {
                basketnum++;
            }
            else
            {
                basketnum--;
            }
            Basket.Text = basketnum.ToString();
        }

        private void check5_CheckedChanged(object sender, EventArgs e)
        {
            if (check5.Checked == true)
            {
                basketnum++;
            }
            else
            {
                basketnum--;
            }
            Basket.Text = basketnum.ToString();
        }

        private void check6_CheckedChanged(object sender, EventArgs e)
        {
            if (check6.Checked == true)
            {
                basketnum++;
            }
            else
            {
                basketnum--;
            }
            Basket.Text = basketnum.ToString();
        }

        private void check7_CheckedChanged(object sender, EventArgs e)
        {
            if (check7.Checked == true)
            {
                basketnum++;
            }
            else
            {
                basketnum--;
            }
            Basket.Text = basketnum.ToString();
        }

        private void check8_CheckedChanged(object sender, EventArgs e)
        {
            if (check8.Checked == true)
            {
                basketnum++;
            }
            else
            {
                basketnum--;
            }
            Basket.Text = basketnum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Text","Head",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.OK) 
            { 
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
                this.Close();
            }
        }
    }
}
