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
            int W, H, L;
            string input;

            // User Input
            Console.Write("W: ");
            input = Console.ReadLine();
            W = Convert.ToInt32(input);
            Console.Write("H: ");
            input = Console.ReadLine();
            H = Convert.ToInt32(input);
            Console.Write("L: ");
            input = Console.ReadLine();
            L = Convert.ToInt32(input);
            Console.WriteLine("------------------------------");        

            // New Class Box1 and Box2
            BOX box1 = new BOX(1, 2, 3);
            BOX box2 = new BOX(W, H, L);

            // print Box's W, H and L
            Console.WriteLine("W: " + box2.Width);
            Console.WriteLine("H: " + box2.Height);
            Console.WriteLine("L: " + box2.Length);

            // print Box's area and Volume
            Console.WriteLine("Area: " + box2.Area());
            Console.WriteLine("Volume: " + box2.Volume());
        }
    }
}
