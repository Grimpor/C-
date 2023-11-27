namespace WinEX2
{
    partial class Grim
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
            Hello = new Button();
            Close = new Button();
            name = new TextBox();
            txt1 = new TextBox();
            txtresult = new TextBox();
            txt2 = new TextBox();
            OK = new Button();
            Clear = new Button();
            Calculator = new GroupBox();
            Add = new Button();
            divide = new Button();
            Calculator.SuspendLayout();
            SuspendLayout();
            // 
            // Hello
            // 
            Hello.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Hello.Location = new Point(448, 40);
            Hello.Name = "Hello";
            Hello.Size = new Size(128, 48);
            Hello.TabIndex = 0;
            Hello.Text = "Hello";
            Hello.UseVisualStyleBackColor = true;
            Hello.Click += Hello_Click;
            // 
            // Close
            // 
            Close.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Close.Location = new Point(160, 240);
            Close.Name = "Close";
            Close.Size = new Size(96, 48);
            Close.TabIndex = 1;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // name
            // 
            name.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(96, 48);
            name.Name = "name";
            name.Size = new Size(320, 39);
            name.TabIndex = 2;
            // 
            // txt1
            // 
            txt1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txt1.Location = new Point(24, 64);
            txt1.Name = "txt1";
            txt1.Size = new Size(192, 39);
            txt1.TabIndex = 3;
            // 
            // txtresult
            // 
            txtresult.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtresult.Location = new Point(24, 176);
            txtresult.Name = "txtresult";
            txtresult.Size = new Size(192, 39);
            txtresult.TabIndex = 4;
            // 
            // txt2
            // 
            txt2.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txt2.Location = new Point(24, 120);
            txt2.Name = "txt2";
            txt2.Size = new Size(192, 39);
            txt2.TabIndex = 5;
            // 
            // OK
            // 
            OK.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point);
            OK.Location = new Point(240, 40);
            OK.Name = "OK";
            OK.Size = new Size(96, 48);
            OK.TabIndex = 6;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // Clear
            // 
            Clear.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.Location = new Point(48, 240);
            Clear.Name = "Clear";
            Clear.Size = new Size(96, 48);
            Clear.TabIndex = 7;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Calculator
            // 
            Calculator.Controls.Add(divide);
            Calculator.Controls.Add(Add);
            Calculator.Controls.Add(OK);
            Calculator.Controls.Add(txt2);
            Calculator.Controls.Add(Clear);
            Calculator.Controls.Add(txtresult);
            Calculator.Controls.Add(Close);
            Calculator.Controls.Add(txt1);
            Calculator.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Calculator.Location = new Point(200, 112);
            Calculator.Name = "Calculator";
            Calculator.Size = new Size(384, 320);
            Calculator.TabIndex = 9;
            Calculator.TabStop = false;
            Calculator.Text = "Ex.Calculator";
            // 
            // Add
            // 
            Add.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Add.Location = new Point(240, 96);
            Add.Name = "Add";
            Add.Size = new Size(96, 48);
            Add.TabIndex = 8;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += button1_Click;
            // 
            // divide
            // 
            divide.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point);
            divide.Location = new Point(240, 152);
            divide.Name = "divide";
            divide.Size = new Size(96, 48);
            divide.TabIndex = 9;
            divide.Text = "divide";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // Grim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Calculator);
            Controls.Add(name);
            Controls.Add(Hello);
            Name = "Grim";
            Text = "27/11/2023";
            Calculator.ResumeLayout(false);
            Calculator.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Hello;
        private Button Close;
        private TextBox name;
        private TextBox txt1;
        private TextBox txtresult;
        private TextBox txt2;
        private Button OK;
        private Button Clear;
        private GroupBox Calculator;
        private Button Add;
        private Button divide;
    }
}