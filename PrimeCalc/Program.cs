using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask the user to enter a minimum number (e.g. 0)
            Console.WriteLine("Enter a minimum number (e.g. 0)");
            int min = 0;
            int.TryParse(Console.ReadLine(), out min);

            // ask the user to enter a maximum number (e.g. 100)
            Console.WriteLine("Enter a maximum number (e.g. 100)");
            int max = 0;
            int.TryParse(Console.ReadLine(), out max);


            // loop from the minimum to maximum number
            for(long i = min; i < max; i++)
            {
                // display the number if it's a prime number

            }



        }
    }
}
