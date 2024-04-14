using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coding_Excercise
{
    internal class InsertionSort
    {
        static void Main(string[] args)
        {
            int temp, j;
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
            for (int i = 1; i < size; i++)
            {
                temp = array[i]; 
                j = i - 1;
                while(j>=0 && array[j] > temp)
                {
                    array[j+1] = array[j];
                    j--;
                }
                array[j+1] = temp;
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
Element 1: 7
Element 2: 4
Element 3: 9
Element 4: 1
Element 5: 5

Output:
Array after being sorted:
1 4 5 7 9*/

