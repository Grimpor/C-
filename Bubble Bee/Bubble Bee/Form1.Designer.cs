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
            textName = new TextBox();
            textPassword = new TextBox();
            login = new Button();
            SuspendLayout();
            // 
            // textName
            // 
            textName.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textName.ForeColor = SystemColors.ScrollBar;
            textName.Location = new Point(312, 240);
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
            textPassword.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textPassword.ForeColor = SystemColors.ScrollBar;
            textPassword.Location = new Point(312, 296);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(184, 32);
            textPassword.TabIndex = 1;
            textPassword.Text = "Password";
            textPassword.TextChanged += textPassword_TextChanged;
            textPassword.Enter += textPassword_Enter;
            textPassword.KeyPress += textPassword_KeyPress;
            // 
            // login
            // 
            login.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            login.Location = new Point(360, 352);
            login.Name = "login";
            login.Size = new Size(88, 40);
            login.TabIndex = 2;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BUBBLE_BEE__2_;
            ClientSize = new Size(800, 450);
            Controls.Add(login);
            Controls.Add(textPassword);
            Controls.Add(textName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textName;
        private TextBox textPassword;
        private Button login;
    }
}
