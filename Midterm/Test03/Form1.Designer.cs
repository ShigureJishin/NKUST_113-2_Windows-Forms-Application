namespace Test03
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnToJPY = new System.Windows.Forms.Button();
            this.btnToTWD = new System.Windows.Forms.Button();
            this.txtJPY = new System.Windows.Forms.TextBox();
            this.txtTWD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(72, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "台幣NTD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(451, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "日幣JPY";
            // 
            // btnToJPY
            // 
            this.btnToJPY.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnToJPY.Location = new System.Drawing.Point(236, 38);
            this.btnToJPY.Name = "btnToJPY";
            this.btnToJPY.Size = new System.Drawing.Size(150, 39);
            this.btnToJPY.TabIndex = 2;
            this.btnToJPY.Text = "台幣=>日幣";
            this.btnToJPY.UseVisualStyleBackColor = true;
            this.btnToJPY.Click += new System.EventHandler(this.btnToJPY_Click);
            // 
            // btnToTWD
            // 
            this.btnToTWD.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnToTWD.Location = new System.Drawing.Point(236, 96);
            this.btnToTWD.Name = "btnToTWD";
            this.btnToTWD.Size = new System.Drawing.Size(150, 39);
            this.btnToTWD.TabIndex = 3;
            this.btnToTWD.Text = "台幣<=日幣";
            this.btnToTWD.UseVisualStyleBackColor = true;
            this.btnToTWD.Click += new System.EventHandler(this.btnToTWD_Click);
            // 
            // txtJPY
            // 
            this.txtJPY.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtJPY.Location = new System.Drawing.Point(430, 102);
            this.txtJPY.Name = "txtJPY";
            this.txtJPY.Size = new System.Drawing.Size(143, 33);
            this.txtJPY.TabIndex = 4;
            this.txtJPY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTWD
            // 
            this.txtTWD.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTWD.Location = new System.Drawing.Point(49, 102);
            this.txtTWD.Name = "txtTWD";
            this.txtTWD.Size = new System.Drawing.Size(143, 33);
            this.txtTWD.TabIndex = 5;
            this.txtTWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 172);
            this.Controls.Add(this.txtTWD);
            this.Controls.Add(this.txtJPY);
            this.Controls.Add(this.btnToTWD);
            this.Controls.Add(this.btnToJPY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnToJPY;
        private System.Windows.Forms.Button btnToTWD;
        private System.Windows.Forms.TextBox txtJPY;
        private System.Windows.Forms.TextBox txtTWD;
    }
}

