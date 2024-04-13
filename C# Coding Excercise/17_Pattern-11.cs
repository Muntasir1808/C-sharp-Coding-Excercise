using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding_Excercise
{
    internal class _17_Pattern_11
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int rows))
            {
                int spaces = 0;
                for (int row = 0; row < rows; row++)
                {
                    spaces = rows - row - 1;
                    for (int space = spaces; space >= 0; space--)
                    {
                        Console.Write(" ");
                    }
                    for (int col = 1; col <= (row * 2) + 1; col++)
                    {
                        Console.Write($"{col}");
                    }
                    Console.WriteLine();
                }
               
            }
        }
    }
}
/* Sample Input:
   Enter number of rows: 5
     1
    123
   12345
  1234567
 123456789
 */
