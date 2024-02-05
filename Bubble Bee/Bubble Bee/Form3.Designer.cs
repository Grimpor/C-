namespace Bubble_Bee
{
    partial class Form3
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
            THANKYOU = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            Close = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // THANKYOU
            // 
            THANKYOU.AutoSize = true;
            THANKYOU.BackColor = Color.Transparent;
            THANKYOU.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            THANKYOU.Location = new Point(184, 144);
            THANKYOU.Name = "THANKYOU";
            THANKYOU.Size = new Size(482, 44);
            THANKYOU.TabIndex = 0;
            THANKYOU.Text = "☺ Thank You Customer ☺";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(368, 208);
            label1.Name = "label1";
            label1.Size = new Size(61, 44);
            label1.TabIndex = 1;
            label1.Text = "By";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(208, 272);
            label2.Name = "label2";
            label2.Size = new Size(356, 41);
            label2.TabIndex = 2;
            label2.Text = "Ms. Nantiva Boonpa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(168, 336);
            label3.Name = "label3";
            label3.Size = new Size(278, 41);
            label3.TabIndex = 3;
            label3.Text = "3661051541146";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("TH Kodchasal", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(456, 328);
            label4.Name = "label4";
            label4.Size = new Size(127, 52);
            label4.TabIndex = 4;
            label4.Text = "ป.สสท 1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.channels4_profile_removebg_preview__1__removebg_preview;
            pictureBox1.Location = new Point(304, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Close
            // 
            Close.Font = new Font("Courier New", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Close.Location = new Point(336, 408);
            Close.Name = "Close";
            Close.Size = new Size(104, 40);
            Close.TabIndex = 6;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ดีไซน์ที่ยังไม่ได้ตั้งชื่อ1;
            ClientSize = new Size(800, 474);
            Controls.Add(Close);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(THANKYOU);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label THANKYOU;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button Close;
    }
}