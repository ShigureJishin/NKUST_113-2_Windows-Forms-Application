using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double rate = 0.04;
            double money = 1_500_000;
            int year = 10;

            for (int i = 0; i < year; i++)
            {
                money += (money * rate);
                // Console.WriteLine(money);
            }

            Console.WriteLine("本金: 1,500,000元");
            Console.WriteLine("年利率: 4%");
            Console.WriteLine("10年後，要還 {0} 元", money);
            Console.WriteLine("按任一鍵後繼續...");
            Console.Read();
        }
    }
}
