using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace TEST02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double Rate = 32.1;
            int USD = 554;
            Console.WriteLine("美金${0} \n轉換 \n台幣${1}", USD, USD*Rate);
            Console.Read();
        }
    }
}
