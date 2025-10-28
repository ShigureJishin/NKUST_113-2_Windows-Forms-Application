namespace Text04
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
            lblResult = new Label();
            txtbMoney = new TextBox();
            txtbYear = new TextBox();
            txtbRate = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnOutput = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 13.8F);
            label1.Location = new Point(98, 72);
            label1.Name = "label1";
            label1.Size = new Size(59, 29);
            label1.TabIndex = 0;
            label1.Text = "本金";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 13.8F);
            label2.Location = new Point(87, 125);
            label2.Name = "label2";
            label2.Size = new Size(82, 29);
            label2.TabIndex = 1;
            label2.Text = "年利率";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 13.8F);
            label3.Location = new Point(110, 180);
            label3.Name = "label3";
            label3.Size = new Size(36, 29);
            label3.TabIndex = 2;
            label3.Text = "借";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Microsoft JhengHei UI", 13.8F);
            lblResult.Location = new Point(189, 238);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 29);
            lblResult.TabIndex = 3;
            // 
            // txtbMoney
            // 
            txtbMoney.Font = new Font("Microsoft JhengHei UI", 13.8F);
            txtbMoney.Location = new Point(189, 72);
            txtbMoney.Name = "txtbMoney";
            txtbMoney.Size = new Size(194, 37);
            txtbMoney.TabIndex = 4;
            // 
            // txtbYear
            // 
            txtbYear.Font = new Font("Microsoft JhengHei UI", 13.8F);
            txtbYear.Location = new Point(189, 177);
            txtbYear.Name = "txtbYear";
            txtbYear.Size = new Size(194, 37);
            txtbYear.TabIndex = 5;
            // 
            // txtbRate
            // 
            txtbRate.Font = new Font("Microsoft JhengHei UI", 13.8F);
            txtbRate.Location = new Point(189, 122);
            txtbRate.Name = "txtbRate";
            txtbRate.Size = new Size(194, 37);
            txtbRate.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 13.8F);
            label5.Location = new Point(389, 75);
            label5.Name = "label5";
            label5.Size = new Size(36, 29);
            label5.TabIndex = 7;
            label5.Text = "元";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 13.8F);
            label6.Location = new Point(389, 130);
            label6.Name = "label6";
            label6.Size = new Size(33, 29);
            label6.TabIndex = 8;
            label6.Text = "%";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 13.8F);
            label7.Location = new Point(389, 180);
            label7.Name = "label7";
            label7.Size = new Size(36, 29);
            label7.TabIndex = 9;
            label7.Text = "年";
            // 
            // btnOutput
            // 
            btnOutput.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnOutput.Location = new Point(87, 234);
            btnOutput.Name = "btnOutput";
            btnOutput.Size = new Size(82, 39);
            btnOutput.TabIndex = 10;
            btnOutput.Text = "計算";
            btnOutput.UseVisualStyleBackColor = true;
            btnOutput.Click += btnOutput_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 386);
            Controls.Add(btnOutput);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtbRate);
            Controls.Add(txtbYear);
            Controls.Add(txtbMoney);
            Controls.Add(lblResult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "還款計算";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblResult;
        private TextBox txtbMoney;
        private TextBox txtbYear;
        private TextBox txtbRate;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnOutput;
    }
}
