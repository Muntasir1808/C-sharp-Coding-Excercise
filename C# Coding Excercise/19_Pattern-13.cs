using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding_Excercise
{
    internal class _19_Pattern_13
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int rows))
            {
                
                for (int row = 1; row <= rows; row++)
                {
                    char alpha = 'A';

                    for (int col = 1; col <= row; col++)
                    {
                        Console.Write($"{alpha}");
                        alpha++;
                    }
                    alpha--;
                    for (int col = row - 1; col >= 1; col--)
                    {
                        alpha--;
                        Console.Write($"{alpha}");
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
A
ABA
ABCBA
ABCDCBA
ABCDEDCBA
 */
