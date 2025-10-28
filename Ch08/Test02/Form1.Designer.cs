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
            btnSumbit = new Button();
            lblNums = new Label();
            SuspendLayout();
            // 
            // btnSumbit
            // 
            btnSumbit.Location = new Point(58, 59);
            btnSumbit.Name = "btnSumbit";
            btnSumbit.Size = new Size(94, 29);
            btnSumbit.TabIndex = 9;
            btnSumbit.Text = "button1";
            btnSumbit.UseVisualStyleBackColor = true;
            btnSumbit.Click += btnSumbit_Click;
            // 
            // lblNums
            // 
            lblNums.AutoSize = true;
            lblNums.Location = new Point(76, 169);
            lblNums.Name = "lblNums";
            lblNums.Size = new Size(51, 19);
            lblNums.TabIndex = 11;
            lblNums.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNums);
            Controls.Add(btnSumbit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumbit;
        private Label lblNums;
    }
}
