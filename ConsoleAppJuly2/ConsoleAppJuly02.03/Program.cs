﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppJuly02._03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++) {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz \n");
                    continue;
                } else if (i % 3 == 0)
                {
                    Console.Write("Fizz \n");
                    continue;
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz \n");
                    continue;
                } else Console.Write(i + "\n");

            }
        }
    }
}
