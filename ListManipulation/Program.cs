using System;

namespace ListManipulation
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
           
        }
    }

}
   
