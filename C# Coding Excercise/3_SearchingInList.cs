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
            Console.Write("Enter a fruit name to search: ");
            var targetFruit = Console.ReadLine();
            var index = fruits.IndexOf(targetFruit);
            if (index != -1)
            {
                Console.WriteLine($"{fruits[index]} is at index {index}");
            }
            else
            {
                Console.WriteLine("Fruit was not found");
            }
        }
    }
}
/* Sample Input:
   Enter a fruit name to search: litchi
   Output
   litchi is at index 1
   Sample Input: guava
   Output: Fruit was not found
 */
