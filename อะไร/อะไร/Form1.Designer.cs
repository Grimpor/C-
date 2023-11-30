namespace อะไร
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
            listsong = new ListBox();
            cmbsong = new ComboBox();
            listFOR = new ListBox();
            listWhile = new ListBox();
            listDowhile = new ListBox();
            listBox4 = new ListBox();
            txtsong = new TextBox();
            txtmovie = new TextBox();
            SuspendLayout();
            // 
            // listsong
            // 
            listsong.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            listsong.FormattingEnabled = true;
            listsong.ItemHeight = 29;
            listsong.Location = new Point(24, 16);
            listsong.Name = "listsong";
            listsong.Size = new Size(280, 207);
            listsong.TabIndex = 0;
            listsong.SelectedIndexChanged += listsong_SelectedIndexChanged;
            // 
            // cmbsong
            // 
            cmbsong.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            cmbsong.FormattingEnabled = true;
            cmbsong.Location = new Point(320, 16);
            cmbsong.Name = "cmbsong";
            cmbsong.Size = new Size(248, 37);
            cmbsong.TabIndex = 1;
            cmbsong.SelectedIndexChanged += cmbsong_SelectedIndexChanged;
            // 
            // listFOR
            // 
            listFOR.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            listFOR.FormattingEnabled = true;
            listFOR.ItemHeight = 29;
            listFOR.Location = new Point(320, 112);
            listFOR.Name = "listFOR";
            listFOR.Size = new Size(144, 265);
            listFOR.TabIndex = 2;
            // 
            // listWhile
            // 
            listWhile.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            listWhile.FormattingEnabled = true;
            listWhile.ItemHeight = 29;
            listWhile.Location = new Point(480, 112);
            listWhile.Name = "listWhile";
            listWhile.Size = new Size(144, 265);
            listWhile.TabIndex = 3;
            // 
            // listDowhile
            // 
            listDowhile.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            listDowhile.FormattingEnabled = true;
            listDowhile.ItemHeight = 29;
            listDowhile.Location = new Point(640, 112);
            listDowhile.Name = "listDowhile";
            listDowhile.Size = new Size(144, 265);
            listDowhile.TabIndex = 4;
            // 
            // listBox4
            // 
            listBox4.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 29;
            listBox4.Location = new Point(792, 112);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(144, 265);
            listBox4.TabIndex = 4;
            // 
            // txtsong
            // 
            txtsong.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            txtsong.Location = new Point(320, 64);
            txtsong.Name = "txtsong";
            txtsong.Size = new Size(248, 37);
            txtsong.TabIndex = 5;
            // 
            // txtmovie
            // 
            txtmovie.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            txtmovie.Location = new Point(24, 240);
            txtmovie.Name = "txtmovie";
            txtmovie.Size = new Size(280, 37);
            txtmovie.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 439);
            Controls.Add(txtmovie);
            Controls.Add(txtsong);
            Controls.Add(listBox4);
            Controls.Add(listDowhile);
            Controls.Add(listWhile);
            Controls.Add(listFOR);
            Controls.Add(cmbsong);
            Controls.Add(listsong);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listsong;
        private ComboBox cmbsong;
        private ListBox listFOR;
        private ListBox listWhile;
        private ListBox listDowhile;
        private ListBox listBox4;
        private TextBox txtsong;
        private TextBox txtmovie;
    }
}
