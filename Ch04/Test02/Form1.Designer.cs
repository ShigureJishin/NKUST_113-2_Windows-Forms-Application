namespace Test02
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
            btnADD = new Button();
            btnSUB = new Button();
            btnMUL = new Button();
            btnDIV = new Button();
            txtbNum1 = new TextBox();
            txtbNum2 = new TextBox();
            label1 = new Label();
            lblOUT = new Label();
            SuspendLayout();
            // 
            // btnADD
            // 
            btnADD.Font = new Font("Microsoft JhengHei UI", 18F);
            btnADD.Location = new Point(209, 72);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(94, 52);
            btnADD.TabIndex = 0;
            btnADD.Text = "+";
            btnADD.UseVisualStyleBackColor = true;
            btnADD.Click += btnADD_Click;
            // 
            // btnSUB
            // 
            btnSUB.Font = new Font("Microsoft JhengHei UI", 18F);
            btnSUB.Location = new Point(209, 130);
            btnSUB.Name = "btnSUB";
            btnSUB.Size = new Size(94, 52);
            btnSUB.TabIndex = 1;
            btnSUB.Text = "-";
            btnSUB.UseVisualStyleBackColor = true;
            btnSUB.Click += btnSUB_Click;
            // 
            // btnMUL
            // 
            btnMUL.Font = new Font("Microsoft JhengHei UI", 18F);
            btnMUL.Location = new Point(209, 188);
            btnMUL.Name = "btnMUL";
            btnMUL.Size = new Size(94, 52);
            btnMUL.TabIndex = 2;
            btnMUL.Text = "*";
            btnMUL.UseVisualStyleBackColor = true;
            btnMUL.Click += btnMUL_Click;
            // 
            // btnDIV
            // 
            btnDIV.Font = new Font("Microsoft JhengHei UI", 18F);
            btnDIV.Location = new Point(209, 251);
            btnDIV.Name = "btnDIV";
            btnDIV.Size = new Size(94, 52);
            btnDIV.TabIndex = 3;
            btnDIV.Text = "/";
            btnDIV.UseVisualStyleBackColor = true;
            btnDIV.Click += btnDIV_Click;
            // 
            // txtbNum1
            // 
            txtbNum1.Font = new Font("Microsoft JhengHei UI", 18F);
            txtbNum1.ImeMode = ImeMode.NoControl;
            txtbNum1.Location = new Point(17, 163);
            txtbNum1.Name = "txtbNum1";
            txtbNum1.Size = new Size(144, 46);
            txtbNum1.TabIndex = 4;
            txtbNum1.Text = "0";
            txtbNum1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbNum2
            // 
            txtbNum2.Font = new Font("Microsoft JhengHei UI", 18F);
            txtbNum2.Location = new Point(357, 163);
            txtbNum2.Name = "txtbNum2";
            txtbNum2.Size = new Size(144, 46);
            txtbNum2.TabIndex = 5;
            txtbNum2.Text = "0";
            txtbNum2.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F);
            label1.Location = new Point(584, 166);
            label1.Name = "label1";
            label1.Size = new Size(39, 38);
            label1.TabIndex = 6;
            label1.Text = "=";
            // 
            // lblOUT
            // 
            lblOUT.AutoSize = true;
            lblOUT.Font = new Font("Microsoft JhengHei UI", 18F);
            lblOUT.Location = new Point(709, 166);
            lblOUT.Name = "lblOUT";
            lblOUT.Size = new Size(32, 38);
            lblOUT.TabIndex = 7;
            lblOUT.Text = "?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 395);
            Controls.Add(lblOUT);
            Controls.Add(label1);
            Controls.Add(txtbNum2);
            Controls.Add(txtbNum1);
            Controls.Add(btnDIV);
            Controls.Add(btnMUL);
            Controls.Add(btnSUB);
            Controls.Add(btnADD);
            Name = "Form1";
            Text = "四則計算機";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnADD;
        private Button btnSUB;
        private Button btnMUL;
        private Button btnDIV;
        private TextBox txtbNum1;
        private TextBox txtbNum2;
        private Label label1;
        private Label lblOUT;
    }
}
