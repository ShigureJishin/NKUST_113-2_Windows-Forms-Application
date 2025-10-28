using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        public static int sum(int a, int b, int c, int d, int e)
        {
            return a + b + c + d + e;
        }
        public static double average(int a, int b, int c, int d, int e)
        {
            return (a + b + c + d + e) / 5;
        }
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5;
            string input;
            Console.Write("第 1 個成績: ");
            input = Console.ReadLine();
            num1 = Convert.ToInt32(input);
            Console.Write("第 2 個成績: ");
            input = Console.ReadLine();
            num2 = Convert.ToInt32(input);
            Console.Write("第 3 個成績: ");
            input = Console.ReadLine();
            num3 = Convert.ToInt32(input);
            Console.Write("第 4 個成績: ");
            input = Console.ReadLine();
            num4 = Convert.ToInt32(input);
            Console.Write("第 5 個成績: ");
            input = Console.ReadLine();
            num5 = Convert.ToInt32(input);

            Console.WriteLine("總和: " + sum(num1, num2, num3, num4, num5));
            Console.WriteLine("平均: " + average(num1, num2, num3, num4, num5));
        }
    }
}
