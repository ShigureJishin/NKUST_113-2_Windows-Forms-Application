using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size_m = 5;
            double size_cm = 100.0 * size_m;
            const int limit_cm = 20;

            int count=0;
            //Console.WriteLine(count.ToString() + ". " + size_cm.ToString());
            while (size_cm > limit_cm)
            {
                count++;
                size_cm /= 2.0;
                //Console.WriteLine(count.ToString() + ". " +size_cm.ToString());
            }

            Console.WriteLine("要對折 " + count.ToString() + " 次!");
            Console.Read();
        }
    }
}
