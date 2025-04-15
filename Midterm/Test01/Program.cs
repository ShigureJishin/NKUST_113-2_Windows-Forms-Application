using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1415;
            double r;
            string input;
            
            Console.Write("請輸入半徑r = ");

            input = Console.ReadLine();
            r = Convert.ToDouble(input);

            Console.WriteLine("半徑{0}，圓周長 = {1}", r, 2 * r * PI);
            Console.WriteLine("半徑{0}，圓面積 = {1}", r, r * r * PI);

            Console.Read();
        }
    }
}
