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
            //Finding out fibonacci number upto 15th place
            var fibonacciNumbers = new List<int> { 1, 1 };
            
            while(fibonacciNumbers.Count <= 15)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(previous + previous2);
            }

            foreach(var number in fibonacciNumbers)
            {
                Console.WriteLine(number);
            }
        }

    }
}
