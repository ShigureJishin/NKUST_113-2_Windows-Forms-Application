using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double year_rate = 0.12; // 12%/year
            const int money = 2000; // 
            double month_rate = year_rate/12;
            int month = 0;
            double buy = 10000;
            double total = 0;

            while ( buy > 0)
            {
                month++;
                if ( month >= 2)
                {
                    if (buy <= money)
                    {
                        total += buy;
                        buy -= buy;
                    }
                    else
                    {
                        total += money;
                        buy -= money;
                    }
                        
                    buy = buy + buy * month_rate;
                }
                else
                {
                    buy = buy + buy * month_rate;
                }
            }

            Console.WriteLine("還款花費月份: " + month.ToString());
            Console.WriteLine("需還款: " + total.ToString() + " 元");
        }
    }
}
