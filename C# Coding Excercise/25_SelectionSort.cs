using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding_Excercise
{
    internal class SelectionSort
    {
        static void Main(string[] args)
        {
            int temp, min;
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
            for(int i = 0; i < size-1; i++)
            {
                min = i;
                for(int j = i+1; j < size; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
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
Element 1: 11
Element 2: 8
Element 3: 13
Element 4: 7
Element 5: 2

Output:
Array after being sorted:
2 7 8 11 13*/
