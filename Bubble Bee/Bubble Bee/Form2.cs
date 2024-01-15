using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubble_Bee
{
    public partial class Form2 : Form
    {
        int num = 0;
        int totaln = 0;
        public Form2()
        {
            InitializeComponent();
        }
        private void checkMilkTea_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMilkTea.Checked == true)
            {
                num++;
                basketlist.Items.Add(milkteaprice.Text);
                totalnum.Text = (totaln += 19).ToString();
            }
            else
            {
                num--;
                basketlist.Items.Remove(milkteaprice.Text);
                totalnum.Text = (totaln -= 19).ToString();
            }
            Basket.Text = num.ToString();
        }

        private void checkThaiTea_CheckedChanged(object sender, EventArgs e)
        {
            if (checkThaiTea.Checked == true)
            {
                num++;
                basketlist.Items.Add(thaiteaprice.Text);
                totalnum.Text = (totaln += 24).ToString();
            }
            else
            {
                num--;
                basketlist.Items.Remove(thaiteaprice.Text);
                totalnum.Text = (totaln -= 24).ToString();
            }
            Basket.Text = num.ToString();
        }

        private void checkGreenTea_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGreenTea.Checked == true)
            {
                num++;
                basketlist.Items.Add(greenteaprice.Text);
                totalnum.Text = (totaln += 24).ToString();
            }
            else
            {
                num--;
                basketlist.Items.Remove(greenteaprice.Text);
                totalnum.Text = (totaln -= 24).ToString();
            }
            Basket.Text = num.ToString();
        }

        private void checkPinkMik_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPinkMik.Checked == true)
            {
                num++;
                basketlist.Items.Add(icedpinkmilkprice.Text);
                totalnum.Text = (totaln += 19).ToString();
            }
            else
            {
                num--;
                basketlist.Items.Remove(icedpinkmilkprice.Text);
                totalnum.Text = (totaln -= 19).ToString();
            }
            Basket.Text = num.ToString();
        }

        private void checkBubb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBubb.Checked == true)
            {
                num++;
                basketlist.Items.Add(bubbleprice.Text);
                totalnum.Text = (totaln += 5).ToString();
            }
            else                                                
            {
                num--;
                basketlist.Items.Remove(bubbleprice.Text);
                totalnum.Text = (totaln -= 5).ToString();
            }
            Basket.Text = num.ToString();
        }

        private void checkSnow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSnow.Checked == true)
            {
                num++;
                basketlist.Items.Add(snowpearlsprice.Text);
                totalnum.Text = (totaln += 5).ToString();
            }
            else
            {
                num--;
                basketlist.Items.Remove(snowpearlsprice.Text);
                totalnum.Text = (totaln -= 5).ToString();
            }
            Basket.Text = num.ToString();
        }

        private void checkPop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPop.Checked == true)
            {
                num++;
                basketlist.Items.Add(bubblepopprice.Text);
                totalnum.Text = (totaln += 5).ToString();
            }
            else
            {
                num--;
                basketlist.Items.Remove(bubblepopprice.Text);
                totalnum.Text = (totaln -= 5).ToString();
            }
            Basket.Text = num.ToString();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(num == 0) 
            {
                MessageBox.Show("Pls choose some product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form3 form3 = new Form3();
                this.Hide();
                form3.ShowDialog();
                this.Close();
            }
        }
    }
}
