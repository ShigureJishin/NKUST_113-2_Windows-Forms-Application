using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int EnterHour, EnterMin, ExitHour, ExitMin;
            int DiffHour, DiffMin;
            int money;


            EnterHour = Convert.ToInt32(txtEnterH.Text);
            EnterMin = Convert.ToInt32(txtEnterM.Text);
            ExitHour = Convert.ToInt32(txtExitH.Text);
            ExitMin = Convert.ToInt32(txtExitM.Text);

            DiffHour = ExitHour - EnterHour;
            DiffMin = ExitMin - EnterMin + DiffHour*60;

            if (DiffMin <= 120)
            {
                money = (DiffMin/30) * 30;
            }
            else if (DiffMin <= 240)
            {
                DiffMin -= 120; 
                money = 120 + (DiffMin/30) * 40;
            }
            else
            {
                DiffMin -= 240;
                money = 120 + 160 + (DiffMin / 30) * 60;
            }

            lblMoney.Text = money.ToString();
        }
    }
}
