using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int n = Convert.ToInt32(input);

            Console.Write(n.ToString()+ " 的因數有 ");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i.ToString() + " ");
                }
            }
        }
    }
}
