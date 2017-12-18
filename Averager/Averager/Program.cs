using System;
using System.Collections.Generic;

namespace Treehouse.Averager
{

    class Program
    {

        static void Main()
        {
            var running = true;
            int timesEntered = 0;
            int total = 0;


            Console.WriteLine("Welcome to Averager.  Give me some numbers and I'll average them for you!");


            while (running)
            {
                Console.WriteLine("Please enter a number or type a letter to compute an average");
                try
                {
                    var input = Console.ReadLine();
                    total += int.Parse(input);
                    timesEntered += 1;
                    Console.WriteLine("Running total: " + total);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Total entered: " + total + ". Divided by " + timesEntered + ", averages " + (total / timesEntered));
                    break;
                }

            }

        }
    }
}


