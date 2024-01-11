namespace Aj.pp_online1
{
    partial class loginform
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
            LoginLabel = new Label();
            LoginGB = new GroupBox();
            loginbutton = new Button();
            password = new TextBox();
            label2 = new Label();
            username = new TextBox();
            label1 = new Label();
            LoginGB.SuspendLayout();
            SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoginLabel.Location = new Point(129, 19);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(104, 24);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "Shoe Tao";
            // 
            // LoginGB
            // 
            LoginGB.BackColor = Color.GhostWhite;
            LoginGB.Controls.Add(loginbutton);
            LoginGB.Controls.Add(password);
            LoginGB.Controls.Add(label2);
            LoginGB.Controls.Add(username);
            LoginGB.Controls.Add(label1);
            LoginGB.Controls.Add(LoginLabel);
            LoginGB.Location = new Point(220, 66);
            LoginGB.Name = "LoginGB";
            LoginGB.Size = new Size(359, 275);
            LoginGB.TabIndex = 1;
            LoginGB.TabStop = false;
            // 
            // loginbutton
            // 
            loginbutton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginbutton.BackColor = Color.CornflowerBlue;
            loginbutton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            loginbutton.Location = new Point(129, 212);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(104, 39);
            loginbutton.TabIndex = 2;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // password
            // 
            password.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            password.ForeColor = Color.Silver;
            password.Location = new Point(15, 151);
            password.Name = "password";
            password.Size = new Size(330, 31);
            password.TabIndex = 1;
            password.Text = "Password";
            password.Enter += password_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 131);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 0;
            label2.Text = "Password :";
            // 
            // username
            // 
            username.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            username.ForeColor = Color.Silver;
            username.Location = new Point(15, 81);
            username.Name = "username";
            username.Size = new Size(330, 31);
            username.TabIndex = 1;
            username.Text = "Username";
            username.Enter += username_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 61);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginGB);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "loginform";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Shoe Tao";
            LoginGB.ResumeLayout(false);
            LoginGB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LoginLabel;
        private GroupBox LoginGB;
        private Button loginbutton;
        private TextBox password;
        private Label label2;
        private TextBox username;
        private Label label1;
    }
}
