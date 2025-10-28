namespace Test04
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
            lblOut = new Label();
            btnSumbit = new Button();
            txtNum4 = new TextBox();
            txtNum3 = new TextBox();
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            txtNum6 = new TextBox();
            txtNum5 = new TextBox();
            SuspendLayout();
            // 
            // lblOut
            // 
            lblOut.AutoSize = true;
            lblOut.Location = new Point(424, 204);
            lblOut.Name = "lblOut";
            lblOut.Size = new Size(51, 19);
            lblOut.TabIndex = 11;
            lblOut.Text = "label1";
            // 
            // btnSumbit
            // 
            btnSumbit.Location = new Point(60, 194);
            btnSumbit.Name = "btnSumbit";
            btnSumbit.Size = new Size(94, 29);
            btnSumbit.TabIndex = 10;
            btnSumbit.Text = "button1";
            btnSumbit.UseVisualStyleBackColor = true;
            // 
            // txtNum4
            // 
            txtNum4.Location = new Point(209, 220);
            txtNum4.Name = "txtNum4";
            txtNum4.Size = new Size(125, 27);
            txtNum4.TabIndex = 9;
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(209, 167);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(125, 27);
            txtNum3.TabIndex = 8;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(209, 116);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(125, 27);
            txtNum2.TabIndex = 7;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(209, 66);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(125, 27);
            txtNum1.TabIndex = 6;
            // 
            // txtNum6
            // 
            txtNum6.Location = new Point(209, 321);
            txtNum6.Name = "txtNum6";
            txtNum6.Size = new Size(125, 27);
            txtNum6.TabIndex = 13;
            // 
            // txtNum5
            // 
            txtNum5.Location = new Point(209, 268);
            txtNum5.Name = "txtNum5";
            txtNum5.Size = new Size(125, 27);
            txtNum5.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNum6);
            Controls.Add(txtNum5);
            Controls.Add(lblOut);
            Controls.Add(btnSumbit);
            Controls.Add(txtNum4);
            Controls.Add(txtNum3);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOut;
        private Button btnSumbit;
        private TextBox txtNum4;
        private TextBox txtNum3;
        private TextBox txtNum2;
        private TextBox txtNum1;
        private TextBox txtNum6;
        private TextBox txtNum5;
    }
}
