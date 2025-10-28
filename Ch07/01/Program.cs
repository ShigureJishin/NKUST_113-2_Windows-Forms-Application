using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    
    internal class Program
    {
        public static int minParameters(int a, int b, int c)
        {
            int min = a;

            if (b < min)
                min = b;
            if (c < min)
                min = c;

            return min;
        }
        public static int maxParameters(int a, int b, int c)
        {
            int max = a;

            if (b > max)
                max = b;
            if (c > max)
                max = c;

            return max;
        }

        static void Main(string[] args)
        {
            int num1, num2, num3;
            string input;
            Console.Write("第 1 個整數: ");
            input = Console.ReadLine();
            num1 = Convert.ToInt32(input);
            Console.Write("第 2 個整數: ");
            input = Console.ReadLine();
            num2 = Convert.ToInt32(input);
            Console.Write("第 3 個整數: ");
            input = Console.ReadLine();
            num3 = Convert.ToInt32(input);

            Console.WriteLine("最小數: " + minParameters(num1, num2, num3).ToString());
            Console.WriteLine("最大數: " + maxParameters(num1, num2, num3).ToString());
        }
    }
}
