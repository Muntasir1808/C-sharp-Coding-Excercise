using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding_Excercise
{
    internal class _20_Pattern_14
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int rows))
            {              
                for (int row = 0; row < rows; row++)
                {                   
                    for (int col = 1; col <= (row * 2) + 1; col++)
                    {
                        Console.Write($"*");
                    }
                    Console.WriteLine();

                }

                for (int row = rows-2; row >= 0; row--)
                {
                    for (int col = 1; col <= (row * 2) + 1; col++)
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
Enter number of rows: 5
Output:
*
***
*****
*******
*********
*******
*****
***
*

 */
