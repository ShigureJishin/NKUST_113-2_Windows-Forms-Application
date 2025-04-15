namespace Test01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtbX_TextChanged(object sender, EventArgs e)
        {
            // empty
        }

        private void txtbY_TextChanged(object sender, EventArgs e)
        {
            // empty
        }

        private void btnOUT_Click(object sender, EventArgs e)
        {
            int x, y, result;
            if (txtbX.Text == " ")
                x = 0;
            else
                x = System.Convert.ToInt32(txtbX.Text);

            if (txtbY.Text == " ")
                y = 0;
            else
                y = System.Convert.ToInt32(txtbY.Text);

            // x*x+2*x+1
            result = x * x + 2 * x + 1;
            lblOUT1.Text = "x*x+2*x+1=" + result.ToString();

            // (x+y) *(x+y) + 20
            result = (x + y) * (x + y) + 20;
            lblOUT2.Text = "(x+y) *(x+y) + 20=" + result.ToString();

            // x*x*x+3*y+5
            result = x * x * x + 3 * y + 5;
            lblOUT3.Text = "x*x*x+3*y+5=" + result.ToString();
        }
    }
}
