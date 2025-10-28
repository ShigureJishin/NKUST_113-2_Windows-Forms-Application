using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03
{
    public class Books
    {
        private string ISBN, Title, Author;
        private int Price;

        public static int Counter = 0;
        public static int TotalPrice = 0;
        public static double AveragePrice;

        public Books(string ISBN, string title, string author, int price)
        {
            this.ISBN = ISBN;
            this.Title = title;
            this.Author = author;
            this.Price = price;

            Counter += 1;
            TotalPrice += price;
            AveragePrice = TotalPrice / Counter;
        }

        public string printBook()
        {
            string output = "";

            output = "ISBN: " + this.ISBN;
            output += "\nTitle: " + this.Title;
            output += "\nAuthor: " + this.Author;
            output += "\nPrice: " + this.Price;

            return output;
        }
    }
}
