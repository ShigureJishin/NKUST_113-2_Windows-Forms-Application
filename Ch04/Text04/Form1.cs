namespace Text04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            double money, rate;
            int year;

            year = System.Convert.ToInt32(txtbYear.Text);
            money = System.Convert.ToDouble(txtbMoney.Text);
            rate = System.Convert.ToDouble(txtbRate.Text);
            rate /= 100;

            for (int i = 0; i < year; i++)
            {
                money +=  (money * rate);
            }

            lblResult.Text = "共需還款 " + money.ToString() + " 元";
        }
    }
}
