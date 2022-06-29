using System;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Array<int> temp = new Array<int>();
            temp.ArrayInfo = new int [5];
            temp[0] =12;
            temp[1]= 13;
            temp[2]= 14;
            temp[3]= 15;
            for(int i =0;i<4;i++)
            {
                Console.WriteLine(temp[i]);
            }
            // foreach(int value in temp.ArrayInfo)
            // {
            //     Console.WriteLine(value);
            // }
        }

   }
}
   
