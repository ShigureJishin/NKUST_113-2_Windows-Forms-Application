namespace Test01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            int[] grades = new int[4];


            // �q��r������o��ƨ��ର���
            grades[0] = Convert.ToInt32(txtStd1.Text);
            grades[1] = Convert.ToInt32(txtStd2.Text);
            grades[2] = Convert.ToInt32(txtStd3.Text);
            grades[3] = Convert.ToInt32(txtStd4.Text);

            int sum = 0;
            for( int i = 0; i< 4; i++ )
                sum += grades[i];

            double average = sum / 4.0;

            lblSum.Text = "�`��: " + sum;
            lblAvg.Text = "����: " + average;

        }
    }
}
