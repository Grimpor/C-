namespace Bubble_Bee
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MilkTea = new GroupBox();
            checkMilkTea = new CheckBox();
            milkteaprice = new Label();
            pictureBox1 = new PictureBox();
            thaitea = new GroupBox();
            checkThaiTea = new CheckBox();
            thaiteaprice = new Label();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            checkPinkMik = new CheckBox();
            icedpinkmilkprice = new Label();
            pictureBox4 = new PictureBox();
            groupBox2 = new GroupBox();
            checkGreenTea = new CheckBox();
            greenteaprice = new Label();
            pictureBox3 = new PictureBox();
            Topping = new GroupBox();
            checkPop = new CheckBox();
            checkSnow = new CheckBox();
            checkBubb = new CheckBox();
            bubblepopprice = new Label();
            snowpearlsprice = new Label();
            bubbleprice = new Label();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox8 = new PictureBox();
            Basket = new Label();
            basketlist = new ListBox();
            login = new Button();
            total = new Label();
            totalnum = new Label();
            groupBox3 = new GroupBox();
            MilkTea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            thaitea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Topping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // MilkTea
            // 
            MilkTea.Controls.Add(checkMilkTea);
            MilkTea.Controls.Add(milkteaprice);
            MilkTea.Controls.Add(pictureBox1);
            MilkTea.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MilkTea.Location = new Point(24, 16);
            MilkTea.Name = "MilkTea";
            MilkTea.Size = new Size(240, 344);
            MilkTea.TabIndex = 0;
            MilkTea.TabStop = false;
            MilkTea.Text = "Milk Tea";
            // 
            // checkMilkTea
            // 
            checkMilkTea.AutoSize = true;
            checkMilkTea.Font = new Font("TH Kodchasal", 18F, FontStyle.Bold, GraphicsUnit.Point);
            checkMilkTea.Location = new Point(24, 288);
            checkMilkTea.Name = "checkMilkTea";
            checkMilkTea.Size = new Size(111, 40);
            checkMilkTea.TabIndex = 5;
            checkMilkTea.Text = "ใส่ตะกร้า";
            checkMilkTea.UseVisualStyleBackColor = true;
            checkMilkTea.CheckedChanged += checkMilkTea_CheckedChanged;
            // 
            // milkteaprice
            // 
            milkteaprice.AutoSize = true;
            milkteaprice.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point);
            milkteaprice.Location = new Point(24, 240);
            milkteaprice.Name = "milkteaprice";
            milkteaprice.Size = new Size(197, 27);
            milkteaprice.TabIndex = 4;
            milkteaprice.Text = "Milk Tea --------------- ฿19";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.messageImage_1705044732360_removebg_preview__1_;
            pictureBox1.Location = new Point(64, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // thaitea
            // 
            thaitea.Controls.Add(checkThaiTea);
            thaitea.Controls.Add(thaiteaprice);
            thaitea.Controls.Add(pictureBox2);
            thaitea.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            thaitea.Location = new Point(312, 16);
            thaitea.Name = "thaitea";
            thaitea.Size = new Size(248, 344);
            thaitea.TabIndex = 1;
            thaitea.TabStop = false;
            thaitea.Text = "Thai Tea";
            // 
            // checkThaiTea
            // 
            checkThaiTea.AutoSize = true;
            checkThaiTea.Font = new Font("TH Kodchasal", 18F, FontStyle.Bold, GraphicsUnit.Point);
            checkThaiTea.Location = new Point(24, 288);
            checkThaiTea.Name = "checkThaiTea";
            checkThaiTea.Size = new Size(111, 40);
            checkThaiTea.TabIndex = 6;
            checkThaiTea.Text = "ใส่ตะกร้า";
            checkThaiTea.UseVisualStyleBackColor = true;
            checkThaiTea.CheckedChanged += checkThaiTea_CheckedChanged;
            // 
            // thaiteaprice
            // 
            thaiteaprice.AutoSize = true;
            thaiteaprice.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point);
            thaiteaprice.Location = new Point(32, 240);
            thaiteaprice.Name = "thaiteaprice";
            thaiteaprice.Size = new Size(198, 27);
            thaiteaprice.TabIndex = 5;
            thaiteaprice.Text = "Thai Tea --------------- ฿24";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.messageImage_1705047228699_removebg_preview;
            pictureBox2.Location = new Point(80, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 168);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkPinkMik);
            groupBox1.Controls.Add(icedpinkmilkprice);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(888, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(264, 344);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Iced Pink Milk";
            // 
            // checkPinkMik
            // 
            checkPinkMik.AutoSize = true;
            checkPinkMik.Font = new Font("TH Kodchasal", 18F, FontStyle.Bold, GraphicsUnit.Point);
            checkPinkMik.Location = new Point(16, 288);
            checkPinkMik.Name = "checkPinkMik";
            checkPinkMik.Size = new Size(111, 40);
            checkPinkMik.TabIndex = 8;
            checkPinkMik.Text = "ใส่ตะกร้า";
            checkPinkMik.UseVisualStyleBackColor = true;
            checkPinkMik.CheckedChanged += checkPinkMik_CheckedChanged;
            // 
            // icedpinkmilkprice
            // 
            icedpinkmilkprice.AutoSize = true;
            icedpinkmilkprice.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point);
            icedpinkmilkprice.Location = new Point(16, 240);
            icedpinkmilkprice.Name = "icedpinkmilkprice";
            icedpinkmilkprice.Size = new Size(239, 27);
            icedpinkmilkprice.TabIndex = 8;
            icedpinkmilkprice.Text = "Iced Pink Milk  --------------- ฿19";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.นมเย็น_1_removebg_preview;
            pictureBox4.Location = new Point(48, 40);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(168, 168);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkGreenTea);
            groupBox2.Controls.Add(greenteaprice);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(592, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(256, 344);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Green Tea";
            // 
            // checkGreenTea
            // 
            checkGreenTea.AutoSize = true;
            checkGreenTea.Font = new Font("TH Kodchasal", 18F, FontStyle.Bold, GraphicsUnit.Point);
            checkGreenTea.Location = new Point(32, 288);
            checkGreenTea.Name = "checkGreenTea";
            checkGreenTea.Size = new Size(111, 40);
            checkGreenTea.TabIndex = 7;
            checkGreenTea.Text = "ใส่ตะกร้า";
            checkGreenTea.UseVisualStyleBackColor = true;
            checkGreenTea.CheckedChanged += checkGreenTea_CheckedChanged;
            // 
            // greenteaprice
            // 
            greenteaprice.AutoSize = true;
            greenteaprice.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point);
            greenteaprice.Location = new Point(32, 240);
            greenteaprice.Name = "greenteaprice";
            greenteaprice.Size = new Size(213, 27);
            greenteaprice.TabIndex = 6;
            greenteaprice.Text = "Green Tea  --------------- ฿24";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.messageImage_1705047326601_removebg_preview;
            pictureBox3.Location = new Point(80, 40);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 168);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // Topping
            // 
            Topping.Controls.Add(checkPop);
            Topping.Controls.Add(checkSnow);
            Topping.Controls.Add(checkBubb);
            Topping.Controls.Add(bubblepopprice);
            Topping.Controls.Add(snowpearlsprice);
            Topping.Controls.Add(bubbleprice);
            Topping.Controls.Add(pictureBox7);
            Topping.Controls.Add(pictureBox6);
            Topping.Controls.Add(pictureBox5);
            Topping.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Topping.Location = new Point(24, 384);
            Topping.Name = "Topping";
            Topping.Size = new Size(544, 256);
            Topping.TabIndex = 5;
            Topping.TabStop = false;
            Topping.Text = "Topping";
            // 
            // checkPop
            // 
            checkPop.AutoSize = true;
            checkPop.Font = new Font("TH Kodchasal", 18F, FontStyle.Bold, GraphicsUnit.Point);
            checkPop.Location = new Point(368, 216);
            checkPop.Name = "checkPop";
            checkPop.Size = new Size(111, 40);
            checkPop.TabIndex = 11;
            checkPop.Text = "ใส่ตะกร้า";
            checkPop.UseVisualStyleBackColor = true;
            checkPop.CheckedChanged += checkPop_CheckedChanged;
            // 
            // checkSnow
            // 
            checkSnow.AutoSize = true;
            checkSnow.Font = new Font("TH Kodchasal", 18F, FontStyle.Bold, GraphicsUnit.Point);
            checkSnow.Location = new Point(192, 216);
            checkSnow.Name = "checkSnow";
            checkSnow.Size = new Size(111, 40);
            checkSnow.TabIndex = 10;
            checkSnow.Text = "ใส่ตะกร้า";
            checkSnow.UseVisualStyleBackColor = true;
            checkSnow.CheckedChanged += checkSnow_CheckedChanged;
            // 
            // checkBubb
            // 
            checkBubb.AutoSize = true;
            checkBubb.Font = new Font("TH Kodchasal", 18F, FontStyle.Bold, GraphicsUnit.Point);
            checkBubb.Location = new Point(24, 216);
            checkBubb.Name = "checkBubb";
            checkBubb.Size = new Size(111, 40);
            checkBubb.TabIndex = 9;
            checkBubb.Text = "ใส่ตะกร้า";
            checkBubb.UseVisualStyleBackColor = true;
            checkBubb.CheckedChanged += checkBubb_CheckedChanged;
            // 
            // bubblepopprice
            // 
            bubblepopprice.AutoSize = true;
            bubblepopprice.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            bubblepopprice.Location = new Point(368, 184);
            bubblepopprice.Name = "bubblepopprice";
            bubblepopprice.Size = new Size(164, 22);
            bubblepopprice.TabIndex = 9;
            bubblepopprice.Text = "Bubble Pop -------------- ฿5";
            // 
            // snowpearlsprice
            // 
            snowpearlsprice.AutoSize = true;
            snowpearlsprice.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            snowpearlsprice.Location = new Point(200, 184);
            snowpearlsprice.Name = "snowpearlsprice";
            snowpearlsprice.Size = new Size(153, 22);
            snowpearlsprice.TabIndex = 8;
            snowpearlsprice.Text = "Snow Pearls ----------- ฿5";
            // 
            // bubbleprice
            // 
            bubbleprice.AutoSize = true;
            bubbleprice.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            bubbleprice.Location = new Point(24, 184);
            bubbleprice.Name = "bubbleprice";
            bubbleprice.Size = new Size(135, 22);
            bubbleprice.TabIndex = 5;
            bubbleprice.Text = "Bubble ------------- ฿5";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.messageImage_1705048600076_removebg_preview;
            pictureBox7.Location = new Point(376, 40);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(152, 128);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.messageImage_1705048664331_removebg_preview;
            pictureBox6.Location = new Point(200, 40);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(152, 128);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.messageImage_1705048572646_removebg_preview1;
            pictureBox5.Location = new Point(16, 40);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(152, 128);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources._21f1b87966512717c47e225a9738de0d;
            pictureBox8.Location = new Point(328, 192);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(72, 80);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            // 
            // Basket
            // 
            Basket.AutoSize = true;
            Basket.BackColor = Color.White;
            Basket.Font = new Font("Dubai", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            Basket.ForeColor = Color.Red;
            Basket.Location = new Point(384, 184);
            Basket.Name = "Basket";
            Basket.Size = new Size(24, 32);
            Basket.TabIndex = 8;
            Basket.Text = "0";
            // 
            // basketlist
            // 
            basketlist.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point);
            basketlist.FormattingEnabled = true;
            basketlist.ItemHeight = 27;
            basketlist.Location = new Point(8, 24);
            basketlist.Name = "basketlist";
            basketlist.Size = new Size(296, 301);
            basketlist.TabIndex = 10;
            // 
            // login
            // 
            login.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            login.Location = new Point(328, 296);
            login.Name = "login";
            login.Size = new Size(88, 40);
            login.TabIndex = 11;
            login.Text = "Buy";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point);
            total.Location = new Point(0, 328);
            total.Name = "total";
            total.Size = new Size(280, 27);
            total.TabIndex = 12;
            total.Text = "Total --------------------------------------";
            // 
            // totalnum
            // 
            totalnum.AutoSize = true;
            totalnum.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalnum.Location = new Point(280, 328);
            totalnum.Name = "totalnum";
            totalnum.Size = new Size(21, 27);
            totalnum.TabIndex = 13;
            totalnum.Text = "0";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(totalnum);
            groupBox3.Controls.Add(total);
            groupBox3.Controls.Add(login);
            groupBox3.Controls.Add(basketlist);
            groupBox3.Controls.Add(Basket);
            groupBox3.Controls.Add(pictureBox8);
            groupBox3.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(672, 368);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(432, 352);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Product List";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 734);
            Controls.Add(groupBox3);
            Controls.Add(Topping);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(thaitea);
            Controls.Add(MilkTea);
            Name = "Form2";
            Text = "Form2";
            MilkTea.ResumeLayout(false);
            MilkTea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            thaitea.ResumeLayout(false);
            thaitea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            Topping.ResumeLayout(false);
            Topping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox MilkTea;
        private PictureBox pictureBox1;
        private GroupBox thaitea;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label milkteaprice;
        private Label thaiteaprice;
        private Label greenteaprice;
        private Label icedpinkmilkprice;
        private GroupBox Topping;
        private Label bubbleprice;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Label bubblepopprice;
        private Label snowpearlsprice;
        private CheckBox checkMilkTea;
        private CheckBox checkThaiTea;
        private CheckBox checkPinkMik;
        private CheckBox checkGreenTea;
        private CheckBox checkPop;
        private CheckBox checkSnow;
        private CheckBox checkBubb;
        private PictureBox pictureBox8;
        private Label Basket;
        private ListBox basketlist;
        private Button login;
        private Label total;
        private Label totalnum;
        private GroupBox groupBox3;
    }
}