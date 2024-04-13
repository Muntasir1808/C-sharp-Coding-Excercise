using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding_Excercise
{
    internal class _21_Pattern_15
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int rows))
            {
                var spaces = 0;
                for(int row = 0; row < rows; row++)
                {
                    spaces = rows - row + 1;
                    for (int space = spaces; space >= row; space--)
                    {
                        Console.Write(" ");
                    }
                    for(int col = 1; col <= (2* row) + 1; col++)
                    {
                        Console.Write($"*");
                    }
                    Console.WriteLine();
                }
                //lower
                for (int row = rows -2; row >= 0; row--)
                {
                    spaces = rows - row + 1;
                    for (int space = spaces; space >= row; space--)
                    {
                        Console.Write(" ");
                    }
                    for (int col = 1; col <= (2 * row) + 1; col++)
                    {
                        Console.Write($"*");
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
Ouput:
      *
    ***
  *****
*******
  *****
    ***
      *
 */
