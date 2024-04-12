using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding_Excercise
{
    internal class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number for checking prime: ");
            string input = Console.ReadLine();
            bool isPrime = true;
            if (int.TryParse(input, out int number))
            {
                if (number < 2) {
                    isPrime = false;
                }
                else
                {
                    for(int i = 2; i <= Math.Sqrt(number); i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            Console.WriteLine($"{number} is not a prime");
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        Console.WriteLine($"{number} is a prime number");
                    }
                   
                }
            }
        }
    }
}
/* Sample Input:
   Enter a number for checking prime: 2
   Output:
   2 is a prime number

   Sample Input:
   Enter a number for checking prime: 9
   Output:
   9 is not a prime

   Sample Input:
   Enter a number for checking prime: 17
   Output:
   17 is a prime number
 */
