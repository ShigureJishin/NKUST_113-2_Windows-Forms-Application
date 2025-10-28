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
            Books book1 = new Books("011", "Trible", "leo", 666);
            Books book2 = new Books("012", "Trible", "leo", 666);
            Books book3= new Books("013", "Trible", "leo", 666);

            Console.WriteLine(book1.printBook());
            Console.WriteLine(Books.Counter);
            Console.WriteLine(Books.TotalPrice);
            Console.WriteLine(Books.AveragePrice);
        }
    }
}
