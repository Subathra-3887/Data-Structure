using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        { 
            int numbers;
            Console.WriteLine("Enter the number of elements:");
            numbers= int.Parse(Console.ReadLine());

            int[] array = new int[numbers];
            Console.WriteLine("Enter the numbers to be inserted in the array:");
            for(int i=0;i<numbers;i++)
            {
                array[i]= int.Parse(Console.ReadLine());
            }
            int len = array.Length;
            Sorting new1 = new Sorting();
            new1.InsertionSort(array);
            new1.SelectionSort(array);
            //new1.BubbleSort(array);
            new1.SortMethod(array, 0, len - 1);
            Console.WriteLine("Sorted array using Merge Sort:");
                foreach(int item in array)
                {
                    Console.Write($"{item}\t");
                }
            new1.QuickSort(array, 0, len - 1);
            Console.WriteLine("Sorted array using Merge Sort:");
                foreach(int item in array)
                {
                    Console.Write($"{item}\t");
                }
            new1.QuickSort(array,0,len-1);
             Console.WriteLine("Sorted array using Quick Sort:");
                foreach(int item in array)
                {
                    Console.Write($"{item}\t");
                }    
        }
    }

}
   
