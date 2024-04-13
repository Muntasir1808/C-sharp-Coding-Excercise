using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding_Excercise
{
    internal class _22_Pattern_16
    {
        static void Main(string[] args)
        {
            // Input array from user
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Input target from user
            Console.Write("Enter the target element to search: ");
            int target = Convert.ToInt32(Console.ReadLine());

            // Linear search
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    index = i;
                    break;
                }
            }

            // Print result
            if (index != -1)
            {
                Console.WriteLine($"Element {target} found at index {index}.");
            }
            else
            {
                Console.WriteLine($"Element {target} not found in the array.");
            }
        }
    }
}
/* Sample Input:
Enter the size of the array: 5
Enter the elements of the array:
Element 1: 3
Element 2: 8
Element 3: 5
Element 4: 9
Element 5: 13
Enter the target element to search: 5

Output:
Element 5 found at index 2.
 */
