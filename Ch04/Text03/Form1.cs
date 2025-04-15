using System.Diagnostics.Eventing.Reader;

namespace Text03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double TWD, USD, rate = 0.33;
            USD = System.Convert.ToDouble(txtbUSD.Text);
            if (USD < 0)
            {
                txtbTWD.Text = "Error";
            }
            else
            {
                TWD = USD * rate;
                txtbTWD.Text = TWD.ToString();
            }
        }
    }
}
