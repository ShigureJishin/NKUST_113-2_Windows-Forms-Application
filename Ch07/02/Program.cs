using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{

    internal class Program
    {
    public static int bill(int minutes)
        {
            int Cost = 0;

            if (minutes <= 60)
            {
                Cost = minutes * 2;
                return Cost;
        }
            else
            {
                Cost = 60 * 2 + (minutes - 60) * 1;
                return Cost;
            }
        }

        static void Main(string[] args)
        {
            string input;
            Console.Write("請輸入遊玩時間（分鐘）：");
            input = Console.ReadLine();

            int minutes = Convert.ToInt32(input);

            Console.WriteLine("費用：" + bill(minutes) + " 元");
        }
    }
}
