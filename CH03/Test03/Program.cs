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
            int egg = 200;
            int remain, group;

            remain = egg % 12;
            group = egg / 12;

            Console.WriteLine("籃子{0}個蛋，每12個一打 \n共{1}打，剩下{2}個蛋", egg, group, remain);
            Console.WriteLine("按任一鍵後繼續...");
            Console.Read();
        }
    }
}
