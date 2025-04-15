using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            double Height, Weight, BMI, stand;
            Height = Convert.ToDouble(txtHeight.Text);
            Weight = Convert.ToDouble(txtWeight.Text);

            if (radWomen.Checked)
            {
                stand = Math.Round((Height - 70) * 0.6, 2);
            }
            else
            {
                stand = Math.Round((Height - 80) * 0.7, 2);
            }

            Height = Height / 100;
            BMI = Math.Round(Weight / (Height * Height), 2);

            lblOut.Text = "BMI=" + BMI.ToString() + "\n標準體重 =" + stand.ToString();
        }
    }
}
