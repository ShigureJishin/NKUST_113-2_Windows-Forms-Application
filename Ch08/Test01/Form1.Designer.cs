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
            txtStd1 = new TextBox();
            txtStd2 = new TextBox();
            txtStd3 = new TextBox();
            txtStd4 = new TextBox();
            btnSumbit = new Button();
            lblSum = new Label();
            lblAvg = new Label();
            SuspendLayout();
            // 
            // txtStd1
            // 
            txtStd1.Location = new Point(59, 184);
            txtStd1.Name = "txtStd1";
            txtStd1.Size = new Size(125, 27);
            txtStd1.TabIndex = 0;
            // 
            // txtStd2
            // 
            txtStd2.Location = new Point(239, 184);
            txtStd2.Name = "txtStd2";
            txtStd2.Size = new Size(125, 27);
            txtStd2.TabIndex = 1;
            // 
            // txtStd3
            // 
            txtStd3.Location = new Point(415, 184);
            txtStd3.Name = "txtStd3";
            txtStd3.Size = new Size(125, 27);
            txtStd3.TabIndex = 2;
            // 
            // txtStd4
            // 
            txtStd4.Location = new Point(604, 184);
            txtStd4.Name = "txtStd4";
            txtStd4.Size = new Size(125, 27);
            txtStd4.TabIndex = 3;
            // 
            // btnSumbit
            // 
            btnSumbit.Location = new Point(59, 43);
            btnSumbit.Name = "btnSumbit";
            btnSumbit.Size = new Size(94, 29);
            btnSumbit.TabIndex = 4;
            btnSumbit.Text = "button1";
            btnSumbit.UseVisualStyleBackColor = true;
            btnSumbit.Click += btnSumbit_Click;
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Location = new Point(83, 261);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(51, 19);
            lblSum.TabIndex = 5;
            lblSum.Text = "label1";
            // 
            // lblAvg
            // 
            lblAvg.AutoSize = true;
            lblAvg.Location = new Point(83, 297);
            lblAvg.Name = "lblAvg";
            lblAvg.Size = new Size(51, 19);
            lblAvg.TabIndex = 6;
            lblAvg.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAvg);
            Controls.Add(lblSum);
            Controls.Add(btnSumbit);
            Controls.Add(txtStd4);
            Controls.Add(txtStd3);
            Controls.Add(txtStd2);
            Controls.Add(txtStd1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStd1;
        private TextBox txtStd2;
        private TextBox txtStd3;
        private TextBox txtStd4;
        private Button btnSumbit;
        private Label lblSum;
        private Label lblAvg;
    }
}
