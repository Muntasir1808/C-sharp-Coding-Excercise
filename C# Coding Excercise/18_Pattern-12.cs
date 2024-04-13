using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding_Excercise
{
    internal class _18_Pattern_12
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int rows))
            {
                int spaces = 0;
                for (int row = 1; row <= rows; row++)
                {
                    spaces = rows - row - 1;
                    for (int space = spaces; space >= 0; space--)
                    {
                        Console.Write(" ");
                    }
                    for (int col = 1; col <= row; col++)
                    {
                        Console.Write($"{col}");
                    }
                    for (int col = row -1; col >=1; col--)
                    {
                        Console.Write($"{col}");
                    }

                    Console.WriteLine();
                }

            }
        }
    }
}
/* 
 Sample Input: 
 Enter number of rows: 5
 Output:
    1
   121
  12321
 1234321
123454321
 */
