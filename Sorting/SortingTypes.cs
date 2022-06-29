using System;
namespace Sorting
{
    public partial class Sorting
    {
        static public void MergeMethod(int[] array, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, j;
            left_end = (mid - 1);
            j = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right))
            {
                if (array[left] <= array[mid])
                    temp[j++] = array[left++];
                else
                    temp[j++] = array[mid++];
            }
            while (left <= left_end)
                temp[j++] = array[left++];
            while (mid <= right)
                temp[j++] = array[mid++];
            for (i = 0; i < num_elements; i++)
            {
                array[right] = temp[right];
                right--;
            }
        }
        public void SortMethod(int[] array, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMethod(array, left, mid);
                SortMethod(array, (mid + 1), right);
                MergeMethod(array, left, (mid + 1), right);
            }
        }
        public void QuickSort(int[] array,int l,int h)
        {
            if(l>h)
            {
                return;
            }
            int pivot = array[h];
            int lp = l;
            int rp = h;
            while(lp<rp)
            {
                while(array[lp]<= pivot && lp<rp)
                {
                    lp++;
                }
                while(array[rp]>=pivot && lp<rp)
                {
                    rp++;
                }
                Swap(array,lp,rp);
            } 
            Swap(array,lp,h);
            QuickSort(array,l,lp-1);
            QuickSort(array,lp+1,h);
        }
        public void Swap(int[]array,int index1,int index2)
        {
            int temp = array[index1];
            array[index1]=array[index2];
            array[index2]= temp;
        }
    }
}