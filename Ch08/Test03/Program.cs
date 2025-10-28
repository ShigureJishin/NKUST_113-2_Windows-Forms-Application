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
            //string input = Console.ReadLine();
            string input = "Visual C# 程式設計範例教本";
            Console.WriteLine("字串長度: " + input.Length);
            Console.WriteLine(input.Substring(0, 16));
            Console.WriteLine(input.Substring(2, 4));
        }
    }
}
