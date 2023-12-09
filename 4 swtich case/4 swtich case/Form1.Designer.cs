namespace _4_swtich_case
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
            change = new ListBox();
            ok = new Button();
            X = new TextBox();
            Y = new TextBox();
            From = new Label();
            To = new Label();
            Title = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // change
            // 
            change.Font = new Font("Angsana New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            change.FormattingEnabled = true;
            change.ItemHeight = 29;
            change.Location = new Point(582, 43);
            change.Name = "change";
            change.Size = new Size(236, 236);
            change.TabIndex = 0;
            change.SelectedIndexChanged += change_SelectedIndexChanged;
            // 
            // ok
            // 
            ok.Enabled = false;
            ok.Font = new Font("Angsana New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ok.Location = new Point(157, 292);
            ok.Name = "ok";
            ok.Size = new Size(149, 65);
            ok.TabIndex = 1;
            ok.Text = "แปลงหน่วย";
            ok.UseVisualStyleBackColor = true;
            ok.Click += ok_Click;
            // 
            // X
            // 
            X.Font = new Font("Angsana New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            X.Location = new Point(67, 102);
            X.Name = "X";
            X.Size = new Size(315, 37);
            X.TabIndex = 2;
            X.TextChanged += X_TextChanged;
            X.KeyPress += X_KeyPress;
            // 
            // Y
            // 
            Y.Font = new Font("Angsana New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Y.Location = new Point(67, 213);
            Y.Name = "Y";
            Y.Size = new Size(315, 37);
            Y.TabIndex = 3;
            Y.KeyPress += Y_KeyPress;
            // 
            // From
            // 
            From.AutoSize = true;
            From.Font = new Font("Angsana New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            From.Location = new Point(431, 110);
            From.Name = "From";
            From.Size = new Size(49, 29);
            From.TabIndex = 4;
            From.Text = "หน่วย";
            // 
            // To
            // 
            To.AutoSize = true;
            To.Font = new Font("Angsana New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            To.Location = new Point(431, 221);
            To.Name = "To";
            To.Size = new Size(49, 29);
            To.TabIndex = 5;
            To.Text = "หน่วย";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Angsana New", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(138, 52);
            Title.TabIndex = 6;
            Title.Text = "แปลงหน่วย";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Angsana New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(195, 163);
            label1.Name = "label1";
            label1.Size = new Size(68, 29);
            label1.TabIndex = 7;
            label1.Text = "แปลงเป็น";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 450);
            Controls.Add(label1);
            Controls.Add(Title);
            Controls.Add(To);
            Controls.Add(From);
            Controls.Add(Y);
            Controls.Add(X);
            Controls.Add(ok);
            Controls.Add(change);
            Name = "Form1";
            Text = "การแปลงหน่วย";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox change;
        private Button ok;
        private TextBox X;
        private TextBox Y;
        private Label From;
        private Label To;
        private Label Title;
        private Label label1;
    }
}
