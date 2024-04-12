using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding_Excercise
{
    internal class SearchingInList
    {
        static void Main(string[] args)
        {
            var fruits = new List<string> { "mango", "litchi", "banana", "coconut", "berry", "apple" };
            var index = fruits.IndexOf("litchi");
            if (index != -1)
            {
                Console.WriteLine($"{fruits[index]} is at index {index}");
            }
        }
    }
}
