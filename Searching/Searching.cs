using System;
namespace Searching
{
    public class Searching
    {
        public void LinearSearch(int[]array)
        {
            bool type = false;
            Console.WriteLine("Enter the number to search:");
            int value = int.Parse(Console.ReadLine());
            for(int i = 0;i<array.Length;i++)
            {
                if(value.Equals(array[i]))
                {
                    type = true;
                    Console.WriteLine($"The value if found at position: {i}");
                }
            }
            if(!type)
            {
                Console.WriteLine("The value is not present in the array");
            }
        }
        public void BinarySearch(int[]array)
        {
            int i,j;
            int temp =0;
            for(i =0;i<array.Length-1;i++)
            {
                for(j=0;j<array.Length-1-i;j++)
                {
                    if(array[j]>array[j+1])
                    {
                        temp=array[j+1];
                        array[j]=array[j+1];
                        array[j+1]= temp;
                    }
                }
            }
            int begin=0,mid=0,end;
            Console.WriteLine("Enter the element to find:");
            int find = int.Parse(Console.ReadLine());

            while(find!= array[mid])
            {
                mid = (begin+array.Length-1)/2;
                if(find==array[mid])
                {
                    Console.WriteLine(mid);
                }
                else if (find<array[mid])
                {
                    end=mid-1;
                }
                else
                {
                    begin=mid+1;
                }
            }
        }
    }
}