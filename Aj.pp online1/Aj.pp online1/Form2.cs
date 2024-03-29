﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Aj.pp_online1
{
    public partial class form2 : Form
    {
        int basketnum = 0;
        int total = 0;
        List<string> basketlist = new List<string>();
        public form2()
        {
            InitializeComponent();
        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            if (check1.Checked == true)
            {
                basketnum++;
                basketlist.Add(label1.Text);
                buylist.Items.Add(label1.Text);
                total += 3919;
            }
            else
            {
                basketnum--;
                basketlist.Remove(label1.Text);
                buylist.Items.Remove(label1.Text);
                total -= 3919;

            }
            price.Text = total.ToString();
            Basket.Text = basketnum.ToString();

        }

        private void check2_CheckedChanged(object sender, EventArgs e)
        {
            if (check2.Checked == true)
            {
                basketnum++;
                basketlist.Add(label2.Text);
                buylist.Items.Add(label2.Text);
                total += 3800;
            }
            else
            {
                basketnum--;
                basketlist.Remove(label2.Text);
                buylist.Items.Remove(label3.Text);
                total -= 3800;
            }
            price.Text = total.ToString();
            Basket.Text = basketnum.ToString();
        }

        private void check3_CheckedChanged(object sender, EventArgs e)
        {
            if (check3.Checked == true)
            {
                basketnum++;
                basketlist.Add(label3.Text);
                buylist.Items.Add(label3.Text);
                total += 3870;
            }
            else
            {
                basketnum--;
                basketlist.Remove(label3.Text);
                buylist.Items.Remove(label3.Text);
                total -= 3870;
            }
            price.Text = total.ToString();
            Basket.Text = basketnum.ToString();
        }

        private void check4_CheckedChanged(object sender, EventArgs e)
        {
            if (check4.Checked == true)
            {
                basketnum++;
                basketlist.Add(label4.Text);
                buylist.Items.Add(label4.Text);
                total += 4300;
            }
            else
            {
                basketnum--;
                basketlist.Remove(label4.Text);
                buylist.Items.Remove(label4.Text);
                total -= 4300;
            }
            price.Text = total.ToString();
            Basket.Text = basketnum.ToString();
        }

        private void check5_CheckedChanged(object sender, EventArgs e)
        {
            if (check5.Checked == true)
            {
                basketnum++;
                basketlist.Add(label5.Text);
                buylist.Items.Add(label5.Text);
                total += 3200;
            }
            else
            {
                basketnum--;
                basketlist.Remove(label5.Text);
                buylist.Items.Remove(label5.Text);
                total -= 3200;
            }
            price.Text = total.ToString();
            Basket.Text = basketnum.ToString();
        }

        private void check6_CheckedChanged(object sender, EventArgs e)
        {
            if (check6.Checked == true)
            {
                basketnum++;
                basketlist.Add(label6.Text);
                buylist.Items.Add(label6.Text);
                total += 8800;
            }
            else
            {
                basketnum--;
                basketlist.Remove(label6.Text);
                buylist.Items.Remove(label6.Text);
                total -= 8800;
            }
            price.Text = total.ToString();
            Basket.Text = basketnum.ToString();
        }

        private void check7_CheckedChanged(object sender, EventArgs e)
        {
            if (check7.Checked == true)
            {
                basketnum++;
                basketlist.Add(label7.Text);
                buylist.Items.Add(label7.Text);
                total += 11130;
            }
            else
            {
                basketnum--;
                basketlist.Remove(label7.Text);
                buylist.Items.Remove(label7.Text);
                total -= 11130;
            }
            price.Text = total.ToString();
            Basket.Text = basketnum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (basketnum == 0)
            {
                MessageBox.Show("โปรดเลือกสินค้าเพื่อทำรายการ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string itemslist = string.Join(",\n ", basketlist);
                DialogResult result = MessageBox.Show($"ยืนยันการสั่งซื้อ : {itemslist} \n ราคาทั้งหมด {total} บาท", "ยินยันการสั่งซื้อ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    this.Hide();
                    Form4 f4 = new Form4();
                    f4.ShowDialog();
                    this.Close();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}

