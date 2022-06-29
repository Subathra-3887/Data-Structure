using System;

namespace ArrayListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
           ArrayList new1 = new ArrayList(0);
            new1.Add(12);
            new1.Add("SUBA");
            new1.Add("Hi");
            new1.Add(4.5);
            new1.Add('c');
            new1.Add(34);
            new1.Add("SF3887");

            for(int i =0 ;i<6;i++)
            {
                if(new1[i]!=null)
                {
                    Console.WriteLine("Elements are:");
                    Console.WriteLine(new1[i]);
                }
            }
            Console.WriteLine("Elements of the array are:");
            foreach(var value in new1.Array)
            {
                if(value!=null)
                {
                    Console.WriteLine(value);
                }
            }
        }
    }

}
   
