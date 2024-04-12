using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding_Excercise
{
    internal class _4_ListSorting
    {
        static void Main(string[] args)
        {
            var fruits = new List<string> { "mango", "litchi", "banana", "coconut", "berry", "apple" };
            fruits.Sort();
            foreach (var fruit in fruits)
            {
                Console.Write($" {fruit}");
            }
            Console.WriteLine();
        }
    }
}
