using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding_Excercise
{
    internal class BubbleSort
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


            //Outer loop represents the number of elements to sort
            for (int i = 0; i < size-1; i++)
            {
                //inner for loop does the adjacent comparison
                for(int j = 0; j < size-1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }
            Console.WriteLine("Array after being sorted: ");
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
/*
Sample Input:
Enter the size of the array: 5
Enter the elements of the array in ascending order:
Element 1: 9
Element 2: 7
Element 3: 8
Element 4: 5
Element 5: 2

Output:
Array after being sorted:
2 5 7 8 9  */
