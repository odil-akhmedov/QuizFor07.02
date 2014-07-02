using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppJuly2
{
    class Program
    {
        public static int smallest(int a, int b) {
            if (a < b)
                return a;
            else if (b < a)
                return b;
            else return default(int);
        }
        static void Main(string[] args)
        {
            int a, b, result;
            //Console.Write("Enter two integers followed by 'Enter' each: ");
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());
            //or like this 

            Console.Write("Please two integers separated by a space: ");
            var allNumbers = Console.ReadLine().Split(' ').Take(2);
            int[] numbers = allNumbers.Select(d => Convert.ToInt32(d)).ToArray();

            //result = smallest(a, b);
            //Console.WriteLine("The smallest of 2 integers (" + a + ", " + b + ") you inputted is " + result);
            result = smallest(numbers[0], numbers[1]);
            Console.WriteLine("The smallest of 2 integers (" + numbers[0] + ", " + numbers[1] + ") you inputted is " + result);

        }
    }
}
