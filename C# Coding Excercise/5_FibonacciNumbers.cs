using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding_Excercise
{
    internal class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            //Finding out fibonacci number upto nth place
            var fibonacciNumbers = new List<int> { 1, 1 };
            Console.Write("Enter fibonacci number's place: ");
            string input = Console.ReadLine();
            int nthPlace = int.Parse(input);

            while (fibonacciNumbers.Count <= nthPlace)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(previous + previous2);
            }

            foreach(var number in fibonacciNumbers)
            {
                Console.Write($" {number}");
            }
            Console.WriteLine();
        }

    }
}
/* Sample Input:
   Enter fibonacci number's place: 6
   Output:
   1 1 2 3 5 8 13
   Enter fibonacci number's place: 8
   1 1 2 3 5 8 13 21 34
 */
