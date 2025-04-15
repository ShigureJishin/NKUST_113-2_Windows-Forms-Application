namespace Test01
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
            txtbX = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtbY = new TextBox();
            lblOUT1 = new Label();
            lblOUT2 = new Label();
            lblOUT3 = new Label();
            btnOUT = new Button();
            SuspendLayout();
            // 
            // txtbX
            // 
            txtbX.Location = new Point(102, 17);
            txtbX.Name = "txtbX";
            txtbX.Size = new Size(125, 27);
            txtbX.TabIndex = 0;
            txtbX.Text = "0";
            txtbX.TextAlign = HorizontalAlignment.Center;
            txtbX.TextChanged += txtbX_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 20);
            label1.Name = "label1";
            label1.Size = new Size(30, 19);
            label1.TabIndex = 1;
            label1.Text = "X=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 63);
            label2.Name = "label2";
            label2.Size = new Size(29, 19);
            label2.TabIndex = 3;
            label2.Text = "Y=";
            // 
            // txtbY
            // 
            txtbY.Location = new Point(102, 60);
            txtbY.Name = "txtbY";
            txtbY.Size = new Size(125, 27);
            txtbY.TabIndex = 2;
            txtbY.Text = "0";
            txtbY.TextAlign = HorizontalAlignment.Center;
            txtbY.TextChanged += txtbY_TextChanged;
            // 
            // lblOUT1
            // 
            lblOUT1.AutoSize = true;
            lblOUT1.Location = new Point(102, 150);
            lblOUT1.Name = "lblOUT1";
            lblOUT1.Size = new Size(102, 19);
            lblOUT1.TabIndex = 4;
            lblOUT1.Text = "x*x+2*x+1=?";
            // 
            // lblOUT2
            // 
            lblOUT2.AutoSize = true;
            lblOUT2.Location = new Point(57, 197);
            lblOUT2.Name = "lblOUT2";
            lblOUT2.Size = new Size(147, 19);
            lblOUT2.TabIndex = 5;
            lblOUT2.Text = "(x+y) *(x+y) + 20=?";
            // 
            // lblOUT3
            // 
            lblOUT3.AutoSize = true;
            lblOUT3.Location = new Point(87, 242);
            lblOUT3.Name = "lblOUT3";
            lblOUT3.Size = new Size(117, 19);
            lblOUT3.TabIndex = 6;
            lblOUT3.Text = "x*x*x+3*y+5=?";
            // 
            // btnOUT
            // 
            btnOUT.Location = new Point(233, 20);
            btnOUT.Name = "btnOUT";
            btnOUT.Size = new Size(94, 67);
            btnOUT.TabIndex = 7;
            btnOUT.Text = "計算";
            btnOUT.UseVisualStyleBackColor = true;
            btnOUT.Click += btnOUT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 368);
            Controls.Add(btnOUT);
            Controls.Add(lblOUT3);
            Controls.Add(lblOUT2);
            Controls.Add(lblOUT1);
            Controls.Add(label2);
            Controls.Add(txtbY);
            Controls.Add(label1);
            Controls.Add(txtbX);
            Name = "Form1";
            Text = "計算運算式(x,y)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbX;
        private Label label1;
        private Label label2;
        private TextBox txtbY;
        private Label lblOUT1;
        private Label lblOUT2;
        private Label lblOUT3;
        private Button btnOUT;
    }
}
