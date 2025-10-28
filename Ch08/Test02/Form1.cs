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

            // 產生隨機整數
            for (int i = 0; i < Nums.Length; i++)
            {
                Nums[i] = rnd.Next(1, 201); // 上限是201，代表範圍是 1~200        
            }

            // 方法二 泡沫排序
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

            // 方法一 排序陣列
            Array.Sort(Nums);

            string result = "";

            for (int i = 0; i < Nums.Length;i++)
                result += Nums[i] + " ";
            lblNums.Text = "排序後陣列內容: " + result;

        }
    }
}
