using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess;
            int x = 1;
            int y = 100;
            string input;



            Console.WriteLine("Think of a number between 1 and 100");
            while (true)
            {
                guess = (x + y) / 2;

                Console.WriteLine("Is the number {0}", guess);

                Console.WriteLine("h, l, or e");

                input = Console.ReadLine();
                if (input == "h")
                {
                    x = guess + 1;
                }
                if (input == "l")
                {
                    y = guess - 1;
                }
                if (input == "e")
                {
                    break;
                }

            }
        }
    }
}