using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        public static int mul(int num, int count)
        {
            if (count == 1)
                return num;
            else
                return num * mul(num, count - 1);
        }
        static void Main(string[] args)
        {
            int x, n; // x^n
            string input;
            Console.WriteLine("x^n");
            Console.Write("輸入底數x: ");
            input = Console.ReadLine();
            x = Convert.ToInt32(input);

            Console.Write("輸入次方n: ");
            input = Console.ReadLine();
            n = Convert.ToInt32(input);

            Console.WriteLine("Ans: " + mul(x, n).ToString());
        }
    }
}
