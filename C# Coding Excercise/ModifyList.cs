using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding_Excercise
{
    internal class ModifyList
    {
        static void Main(string[] args)
        {
            var fruits = new List<string> {"mango", "litchi", "banana", "coconut"};
            fruits.Add("jackfruit");
            fruits.Remove("litchi");

            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
/*OUTPUT:
mango
banana
coconut
jackfruit*/

