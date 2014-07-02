using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppJuly2._02
{
    class Book {
        private int price1;

       public Book(int bookPrice) {
            this.Price = bookPrice;
        }

        /*public Book(int price1)
        {
            // TODO: Complete member initialization
            this.price1 = price1;
        }*/
        public int Price { get; set; }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            int price1, price2;
            Console.WriteLine("Enter the price of the first book: ");
            price1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the price of the second book: ");
            price2 = Convert.ToInt32(Console.ReadLine());
            
            Book firstBook = new Book(price1);
            Book secondBook = new Book(price2);

            switch (comparePrices(firstBook, secondBook)) { 
                case 0:
                    Console.WriteLine("The prices are the same");
                    break;
                case 1:
                    Console.WriteLine("The first book is more expensive than the second");
                    break;
                case -1:
                    Console.WriteLine("The first book is cheaper than the second");
                    break;
                default:
                    Console.WriteLine("Something is wrong...");
                    break;

            }
            Console.ReadLine();

           
        }

        static int comparePrices(Book book1, Book book2) {
            if (book1.Price == book2.Price)
                return 0;
            if (book1.Price > book2.Price)
                return 1;
            if (book1.Price < book2.Price)
                return -1;
            return default(int);
        }
    }
}
