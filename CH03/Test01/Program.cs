using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1415;
            int r;
            double result;

            // 半徑 10 
            r = 10;
            Console.WriteLine("半徑r = {0}，圓周長 = {1} ", r, 2 * PI * 10);

            // 半徑 20
            r = 20;
            Console.WriteLine("半徑r = {0}，圓周長 = {1} ", r, 2 * PI * r);

            // 半徑 50
            r = 50;
            Console.WriteLine("半徑r = {0}，圓周長 = {1} ", r, 2 * PI * r);
            Console.WriteLine("按任一鍵後繼續...");
            Console.Read();
        }
    }
}
