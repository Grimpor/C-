namespace WinCon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(488, 88);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(240, 256);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(320, 248);
            label3.Name = "label3";
            label3.Size = new Size(55, 26);
            label3.TabIndex = 5;
            label3.Text = "หน่วย";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(320, 104);
            label2.Name = "label2";
            label2.Size = new Size(55, 26);
            label2.TabIndex = 4;
            label2.Text = "หน่วย";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new Font("Book Antiqua", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(48, 320);
            button1.Name = "button1";
            button1.Size = new Size(168, 48);
            button1.TabIndex = 3;
            button1.Text = "แปลงหน่วย";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(168, 168);
            label1.Name = "label1";
            label1.Size = new Size(56, 39);
            label1.TabIndex = 2;
            label1.Text = "To";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Book Antiqua", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(80, 232);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 46);
            textBox2.TabIndex = 1;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Book Antiqua", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(80, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 46);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // button2
            // 
            button2.Font = new Font("Book Antiqua", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(240, 320);
            button2.Name = "button2";
            button2.Size = new Size(116, 48);
            button2.TabIndex = 7;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "การแปลงหน่วย";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Button button1;
        private Label label1;
        private TextBox textBox2;
        private ListBox listBox1;
        private Button button2;
    }
}
