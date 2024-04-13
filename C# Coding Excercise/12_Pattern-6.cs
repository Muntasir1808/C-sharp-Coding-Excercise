using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding_Excercise
{
    internal class _12_Pattern_6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int rows))
            {
                int spaces = 0;
                int value = 1;
                for (int row = 1; row <= rows; row++)
                {
                    spaces = rows - row;
                    for (int space = spaces; space >= 0; space--)
                    {
                        Console.Write(" ");
                    }
                    for (int col = 1; col <= row; col++)
                    {
                        Console.Write($"* ");
                        value++;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
/*
Sample Input:
Enter number of rows: 4
Output:
    *
   * *
  * * *
 * * * *

 */
