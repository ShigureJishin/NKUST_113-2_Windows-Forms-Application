namespace Test02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            int[] Nums = new int[5];

            Random rnd = new Random();

            // �����H�����
            for (int i = 0; i < Nums.Length; i++)
            {
                Nums[i] = rnd.Next(1, 201); // �W���O201�A�N��d��O 1~200        
            }

            // ��k�G �w�j�Ƨ�
            for (int i = 0; i < Nums.Length - 1; i++)
            {
                for (int j = 0; j < Nums.Length - 1; j++)
                {
                    if (Nums[j] > Nums[j + 1])
                    {
                        int temp = Nums[j];
                        Nums[j] = Nums[j + 1];
                        Nums[j + 1] = temp;
                    }
                }
            }

            // ��k�@ �Ƨǰ}�C
            Array.Sort(Nums);

            string result = "";

            for (int i = 0; i < Nums.Length;i++)
                result += Nums[i] + " ";
            lblNums.Text = "�Ƨǫ�}�C���e: " + result;

        }
    }
}
