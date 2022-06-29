using System;

namespace Searching
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
            Searching new1 = new Searching();
            new1.LinearSearch(array);
            new1.BinarySearch(array);
               
        }
    }

}
   
