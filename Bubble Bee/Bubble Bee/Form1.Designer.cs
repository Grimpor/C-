namespace Bubble_Bee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textName = new TextBox();
            textPassword = new TextBox();
            login = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textName
            // 
            textName.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textName.ForeColor = SystemColors.ScrollBar;
            textName.Location = new Point(400, 152);
            textName.Multiline = true;
            textName.Name = "textName";
            textName.Size = new Size(184, 32);
            textName.TabIndex = 0;
            textName.Text = "Username";
            textName.TextChanged += textName_TextChanged;
            textName.Enter += textName_Enter;
            // 
            // textPassword
            // 
            textPassword.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textPassword.ForeColor = SystemColors.ScrollBar;
            textPassword.Location = new Point(408, 216);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(184, 32);
            textPassword.TabIndex = 1;
            textPassword.Text = "Password";
            textPassword.Enter += textPassword_Enter;
            // 
            // login
            // 
            login.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            login.Location = new Point(384, 280);
            login.Name = "login";
            login.Size = new Size(88, 40);
            login.TabIndex = 2;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(login);
            groupBox1.Controls.Add(textPassword);
            groupBox1.Controls.Add(textName);
            groupBox1.Font = new Font("Courier New", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(64, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(616, 336);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._0AB884E1_9BA5_4B3D_A0A1_173864622950;
            pictureBox1.Location = new Point(40, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(296, 80);
            label3.Name = "label3";
            label3.Size = new Size(205, 36);
            label3.TabIndex = 6;
            label3.Text = "BUBEE CAFE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(232, 216);
            label2.Name = "label2";
            label2.Size = new Size(166, 27);
            label2.TabIndex = 5;
            label2.Text = "Password : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(240, 152);
            label1.Name = "label1";
            label1.Size = new Size(152, 27);
            label1.TabIndex = 4;
            label1.Text = "Username :";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(766, 457);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "NantivaLogin";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textName;
        private TextBox textPassword;
        private Button login;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
