using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding_Excercise
{
    internal class _8_Pattern_2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int rows))
            {
                for (int row = 1; row <= rows; row++)
                {
                    for (int col = 1; col <= row; col++)
                    {
                        Console.Write(col);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
/*  Sample Input:
    Enter number of rows: 5
    1
    12
    123
    1234
    12345
 */
