using System;
namespace Sorting
{
    public partial class Sorting
    {
        public void InsertionSort(int[] array)
        {
            int i,j;
            int value;
            
            for(i =1;i<array.Length;i++)
            {
                 value = array[i];
                for(j=i-1;j>=0;)
                {
                    if(value<array[j])
                    {
                        array[j+1]=array[j];
                        j--;
                        array[j+1]= value;
                    }
                    else
                    {
                        break;
                    }
                }
            }
             Console.WriteLine("Sorted array using Insertion Sort:");
            foreach(int item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
        public void SelectionSort(int[]array)
        {
            int i,j;
            int temp,min,minIndex;
            for(i=0;i<array.Length;i++)
            {
                min= array[i];
                minIndex=i;
                for(j=i;j<array.Length;j++)
                {
                    if(array[j]<min)
                    {
                        min =array[j];
                        minIndex=j;
                    }
                }
                if(min<array[i])
                {
                    temp=array[i];
                    array[i]= array[minIndex];
                    array[minIndex]=temp;
                }
            }
            Console.WriteLine("Sorted array using Selection Sort:");
            foreach(int item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
        public void BubbleSort(int[]array)
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
            Console.WriteLine("Sorted array using Bubble Sort:");
            foreach(int item in array)
            {
                Console.Write($"{item}\t");
            }
        }
    }
}