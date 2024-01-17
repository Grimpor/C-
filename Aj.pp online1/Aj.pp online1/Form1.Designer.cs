namespace Aj.pp_online1
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            LoginGB = new GroupBox();
            pictureBox1 = new PictureBox();
            loginbutton = new Button();
            username = new TextBox();
            label2 = new Label();
            password = new TextBox();
            label1 = new Label();
            LoginGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginGB
            // 
            LoginGB.BackColor = Color.GhostWhite;
            LoginGB.Controls.Add(pictureBox1);
            LoginGB.Controls.Add(loginbutton);
            LoginGB.Controls.Add(username);
            LoginGB.Controls.Add(label2);
            LoginGB.Controls.Add(password);
            LoginGB.Controls.Add(label1);
            LoginGB.Location = new Point(224, 24);
            LoginGB.Name = "LoginGB";
            LoginGB.Size = new Size(359, 371);
            LoginGB.TabIndex = 1;
            LoginGB.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Shoe_tao1;
            pictureBox1.Location = new Point(72, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // loginbutton
            // 
            loginbutton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginbutton.BackColor = Color.CornflowerBlue;
            loginbutton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            loginbutton.Location = new Point(128, 312);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(104, 39);
            loginbutton.TabIndex = 2;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // username
            // 
            username.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            username.ForeColor = Color.Silver;
            username.Location = new Point(16, 184);
            username.Name = "username";
            username.Size = new Size(330, 31);
            username.TabIndex = 1;
            username.Text = "Username";
            username.Click += password_Click;
            username.TextChanged += username_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 232);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 0;
            label2.Text = "Password :";
            // 
            // password
            // 
            password.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            password.ForeColor = Color.Silver;
            password.Location = new Point(16, 256);
            password.Name = "password";
            password.Size = new Size(330, 31);
            password.TabIndex = 1;
            password.Text = "Password";
            password.Click += username_Click;
            password.TextChanged += password_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 162);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginGB);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Login";
            LoginGB.ResumeLayout(false);
            LoginGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox LoginGB;
        private Button loginbutton;
        private TextBox username;
        private Label label2;
        private TextBox password;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
