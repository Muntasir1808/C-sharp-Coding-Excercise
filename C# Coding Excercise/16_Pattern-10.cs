using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding_Excercise
{
    internal class _16_Pattern_10
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int rows))
            {
                int spaces = 0;
                //reverse pyramid
                for (int row = rows - 2; row >= 0; row--)
                {
                    spaces = rows - row - 1;
                    for (int space = 0; space <= spaces; space++)
                    {
                        Console.Write(" ");
                    }
                    for (int col = 0; col <= (row * 2); col++)
                    {
                        Console.Write($"*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
/* Sample Input:
   Enter number of rows: 5
   Output:
   *******
    *****
     ***
      *
 */
