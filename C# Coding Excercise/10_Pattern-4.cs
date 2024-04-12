using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding_Excercise
{
    internal class _10_Pattern_4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int rows))
            {
                int value = 1;
                for (int row = 1; row <= rows; row++)
                {
                    for (int col = 1; col <= row; col++)
                    {
                        Console.Write($"{value} ");
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
    1
    2 3
    4 5 6
    7 8 9 10
 
 */
