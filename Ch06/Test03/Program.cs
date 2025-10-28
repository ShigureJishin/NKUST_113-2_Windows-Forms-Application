using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);

            double div_sum = 0; // 1 + 1/2 + .... + 1/n
            int mul_sum = 0; // 1*1 + 2*2 + .... + n*n

            for (int i = 1; i <= n; i++)
            {
                div_sum += 1.0/i;
                mul_sum += i*i;
            }

            Console.WriteLine("1 + 1/2 + .... + 1/n= " + div_sum.ToString());
            Console.WriteLine("1*1 + 2*2 + .... + n*n= " + mul_sum.ToString());
        }
    }
}
