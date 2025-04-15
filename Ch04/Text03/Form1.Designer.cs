namespace Text03
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
            button1 = new Button();
            txtbUSD = new TextBox();
            label4 = new Label();
            txtbTWD = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 16.2F);
            label1.Location = new Point(104, 104);
            label1.Name = "label1";
            label1.Size = new Size(71, 36);
            label1.TabIndex = 0;
            label1.Text = "美金";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 16.2F);
            label2.Location = new Point(104, 289);
            label2.Name = "label2";
            label2.Size = new Size(71, 36);
            label2.TabIndex = 1;
            label2.Text = "台幣";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 16.2F);
            button1.Location = new Point(136, 166);
            button1.Name = "button1";
            button1.Size = new Size(120, 80);
            button1.TabIndex = 2;
            button1.Text = "轉換";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtbUSD
            // 
            txtbUSD.Font = new Font("Microsoft JhengHei UI", 16.2F);
            txtbUSD.Location = new Point(197, 101);
            txtbUSD.Name = "txtbUSD";
            txtbUSD.Size = new Size(125, 42);
            txtbUSD.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 16.2F);
            label4.Location = new Point(104, 46);
            label4.Name = "label4";
            label4.Size = new Size(125, 36);
            label4.TabIndex = 5;
            label4.Text = "匯率0.33";
            // 
            // txtbTWD
            // 
            txtbTWD.Enabled = false;
            txtbTWD.Font = new Font("Microsoft JhengHei UI", 16.2F);
            txtbTWD.Location = new Point(197, 283);
            txtbTWD.Name = "txtbTWD";
            txtbTWD.Size = new Size(125, 42);
            txtbTWD.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 392);
            Controls.Add(txtbTWD);
            Controls.Add(label4);
            Controls.Add(txtbUSD);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "台幣轉換成美金";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox txtbUSD;
        private Label label4;
        private TextBox txtbTWD;
    }
}
