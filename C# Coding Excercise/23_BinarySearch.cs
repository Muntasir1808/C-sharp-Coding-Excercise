using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding_Excercise
{
    internal class _23_BinarySearch
    {
        static void Main(string[] args)
        {
            // Input array from user
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter the elements of the array in ascending order:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Input target from user
            Console.Write("Enter the target element to search: ");
            int target = Convert.ToInt32(Console.ReadLine());

            int low = 0;
            int high = size - 1;
            int mid = 0;
            int flag = 0;

            while (low <= high)
            {
                mid = (low + high) / 2; 
                if (target < array[mid])
                {
                    high = mid - 1;
                }
                else if (target > array[mid])
                {
                    low = mid + 1;
                }
                else if (target == array[mid])
                {
                    Console.WriteLine($"{target} found at location {mid}");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Element not found");
            }
        }
    }
}
/*
Sample Input:
Enter the size of the array: 5
Enter the elements of the array in ascending order:
Element 1: 3
Element 2: 5
Element 3: 7
Element 4: 9
Element 5: 13
Enter the target element to search: 9

Output:
9 found at location 3
 */
