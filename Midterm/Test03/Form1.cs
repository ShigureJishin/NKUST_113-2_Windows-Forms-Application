using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToJPY_Click(object sender, EventArgs e)
        {
            const double rate = 4.43;
            double TWD, JPY;

            TWD = Convert.ToDouble(txtTWD.Text);
            JPY = Math.Round(TWD * rate, 2);

            txtJPY.Text = JPY.ToString();
        }

        private void btnToTWD_Click(object sender, EventArgs e)
        {
            const double rate = 4.43;
            double TWD, JPY;

            JPY = Convert.ToDouble(txtJPY.Text);
            TWD = Math.Round(JPY/rate, 2);

            txtTWD.Text = TWD.ToString();

        }
    }
}
