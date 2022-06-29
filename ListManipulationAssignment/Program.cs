using System;

namespace ListManipulationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
           ArrayList<int> aList = new ArrayList<int>();
           aList.AddElement(12);
           aList.AddElement(13);
           aList.AddElement(14);
           aList.AddElement(15);
           aList.AddElement(16);
           aList.AddElement(17);
           aList.AddElement(18);

           Console.WriteLine("Elements of the array are:");
           aList.DisplayArray();
           //aList.RemoveAt(2);
           aList.Insert(5,120);
            aList.DisplayArray();
            aList.LinearSearch(17);

           Console.WriteLine("The elements in the array are:");
           foreach(int number in aList)
           {
               Console.WriteLine(number);
           }
        }
    }

}
   
