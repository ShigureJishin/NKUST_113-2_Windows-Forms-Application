using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        public static int funcA(int x , int y)
        {
            if (x > y)
                return x * y;
            else
                return x + y;
        }
        public static double funcB(int x, int y)
        {
            if (y == 0)
                return -1;
            else
                return (double)x / y;
        }

        static void Main(string[] args)
        {
            int num1, num2;
            string input;
            Console.Write("第 1 個整數: ");
            input = Console.ReadLine();
            num1 = Convert.ToInt32(input);
            Console.Write("第 2 個整數: ");
            input = Console.ReadLine();
            num2 = Convert.ToInt32(input);

            Console.WriteLine("funcA: " + funcA(num1, num2).ToString());
            Console.WriteLine("funcB: " + funcB(num1, num2).ToString());
        }
    }
}
