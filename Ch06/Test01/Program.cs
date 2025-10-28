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
            int i, Sum = 0;
            for (i= 1; i <= 100; i++)
            {
                if(i >= 55 && i <= 67)
                    if (i % 2 == 1)
                    {
                        Console.Write(i.ToString() + " ");
                        Sum += i;
                    }
            }
            Console.WriteLine("\n總和: " + Sum.ToString());
        }
    }
}
