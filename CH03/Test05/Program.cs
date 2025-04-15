using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 15, y = 30;
            // (x+y)*(x-y)
            Console.WriteLine("( x + y )*( x - y ) = {0}", (x + y) * (x - y));
            Console.WriteLine("按任一鍵後繼續...");
            Console.Read();
        }
    }
}
