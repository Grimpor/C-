namespace WinFormsApp2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            X = new TextBox();
            Y = new TextBox();
            Calculate = new TextBox();
            sum = new Button();
            minus = new Button();
            multiply = new Button();
            divide = new Button();
            OK = new Button();
            Clear = new Button();
            Show = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(280, 24);
            label1.Name = "label1";
            label1.Size = new Size(197, 50);
            label1.TabIndex = 0;
            label1.Text = "Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(48, 128);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 1;
            label2.Text = "1st number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(48, 192);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 2;
            label3.Text = "2nd number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(48, 256);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 3;
            label4.Text = "Result";
            // 
            // X
            // 
            X.BorderStyle = BorderStyle.FixedSingle;
            X.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            X.Location = new Point(200, 120);
            X.Name = "X";
            X.Size = new Size(304, 33);
            X.TabIndex = 4;
            X.TextChanged += X_TextChanged;
            X.KeyPress += X_KeyPress;
            // 
            // Y
            // 
            Y.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Y.Location = new Point(200, 184);
            Y.Name = "Y";
            Y.Size = new Size(304, 33);
            Y.TabIndex = 5;
            Y.TextChanged += Y_TextChanged;
            Y.KeyPress += Y_KeyPress;
            // 
            // Calculate
            // 
            Calculate.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Calculate.Location = new Point(200, 248);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(304, 33);
            Calculate.TabIndex = 6;
            Calculate.KeyPress += Calculate_KeyPress;
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI Symbol", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            sum.Location = new Point(547, 73);
            sum.Name = "sum";
            sum.Size = new Size(80, 48);
            sum.TabIndex = 7;
            sum.Text = "+";
            sum.UseVisualStyleBackColor = true;
            sum.Click += sum_Click;
            // 
            // minus
            // 
            minus.Font = new Font("Segoe UI Symbol", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            minus.Location = new Point(547, 137);
            minus.Name = "minus";
            minus.Size = new Size(80, 48);
            minus.TabIndex = 8;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // multiply
            // 
            multiply.Font = new Font("Segoe UI Symbol", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            multiply.Location = new Point(547, 201);
            multiply.Name = "multiply";
            multiply.Size = new Size(80, 48);
            multiply.TabIndex = 9;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += multiply_Click;
            // 
            // divide
            // 
            divide.Font = new Font("Segoe UI Symbol", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            divide.Location = new Point(547, 265);
            divide.Name = "divide";
            divide.Size = new Size(80, 48);
            divide.TabIndex = 10;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // OK
            // 
            OK.Enabled = false;
            OK.Font = new Font("Segoe UI Symbol", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            OK.Location = new Point(104, 352);
            OK.Name = "OK";
            OK.Size = new Size(128, 64);
            OK.TabIndex = 11;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // Clear
            // 
            Clear.Enabled = false;
            Clear.Font = new Font("Segoe UI Symbol", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.Location = new Point(312, 352);
            Clear.Name = "Clear";
            Clear.Size = new Size(128, 64);
            Clear.TabIndex = 12;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Show
            // 
            Show.Enabled = false;
            Show.Font = new Font("Segoe UI Symbol", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            Show.Location = new Point(520, 352);
            Show.Name = "Show";
            Show.Size = new Size(128, 64);
            Show.TabIndex = 13;
            Show.Text = "Show";
            Show.UseVisualStyleBackColor = true;
            Show.Click += Show_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Show);
            Controls.Add(Clear);
            Controls.Add(OK);
            Controls.Add(divide);
            Controls.Add(multiply);
            Controls.Add(minus);
            Controls.Add(sum);
            Controls.Add(Calculate);
            Controls.Add(Y);
            Controls.Add(X);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculate";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox X;
        private TextBox Y;
        private TextBox Calculate;
        private Button sum;
        private Button minus;
        private Button multiply;
        private Button divide;
        private Button OK;
        private Button Clear;
        private Button Show;
    }
}