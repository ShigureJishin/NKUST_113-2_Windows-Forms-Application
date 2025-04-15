namespace Test02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            double num1, num2, Result;
            num1 = System.Convert.ToDouble(txtbNum1.Text);
            num2 = System.Convert.ToDouble(txtbNum2.Text);
            Result = num1 + num2;

            lblOUT.Text = Result.ToString();

        }

        private void btnSUB_Click(object sender, EventArgs e)
        {
            double num1, num2, Result;
            num1 = System.Convert.ToDouble(txtbNum1.Text);
            num2 = System.Convert.ToDouble(txtbNum2.Text);
            Result = num1 - num2;

            lblOUT.Text = Result.ToString();
        }

        private void btnMUL_Click(object sender, EventArgs e)
        {
            double num1, num2, Result;
            num1 = System.Convert.ToDouble(txtbNum1.Text);
            num2 = System.Convert.ToDouble(txtbNum2.Text);
            Result = num1 * num2;

            lblOUT.Text = Result.ToString();
        }

        private void btnDIV_Click(object sender, EventArgs e)
        {
            double num1, num2, Result;
            num1 = System.Convert.ToDouble(txtbNum1.Text);
            num2 = System.Convert.ToDouble(txtbNum2.Text);
            if (num2 == 0)
            {
                lblOUT.Text = "Error";
            }

            else
            {
                Result = num1 / num2;
                lblOUT.Text = Result.ToString();
            }
        }
    }
}
