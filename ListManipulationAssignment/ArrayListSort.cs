using System;
using System.Collections.Generic;
using System.Collections;
namespace ListManipulationAssignment
{
    public partial class ArrayList<T>
    {
        public void BubbleSort()
        {
           int i,j;
            int temp =0;
            for(i =0;i<Array.Length-1;i++)
            {
                for(j=0;j<Array.Length-1-i;j++)
                {
                    if(CompareGreater(Array[j],Array[j+1]))
                    {
                        // temp=Array[j+1];
                        // Array[j+1]=Array[j];
                        // Array[j]= temp;
                    }
                }
            }
        }
        public bool CompareGreater(T value1, T value2)
        {
            var result = Comparer<T>.Default.Compare(value1,value2);
            if(result>=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}