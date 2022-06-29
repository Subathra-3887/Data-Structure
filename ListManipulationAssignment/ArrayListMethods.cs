using System;
namespace ListManipulationAssignment
{
    public partial class ArrayList<T>
    {
        public T [] Array{get; set;}
        public int _count;
        public int _capacity;
        public int Count { get{return _count;}}
        public int Capacity { get{return _capacity;}}
        
        public ArrayList()
        {
            Array = new T[1];
            _count=0;
            _capacity=1;
        }
        public ArrayList(int size)
        {
            _count =0;
            _capacity =size*2;
            Array = new T[_capacity];
        }   
        public void AddElement(T a)
        {
            if(_count==_capacity)
            {
                GrowSize();    
            }
            Array[_count] =a;
            _count++;

        }
        //function to increase the size of array dynamically
        public void GrowSize()
        {
            T[] temp = new T[_capacity*2];
            for(int i =0;i<_capacity;i++)
            {
                temp[i]= Array[i];
            }
            Array =temp;
            _capacity=_capacity*2;
        }   
        public void DisplayArray()
        {
            for(int i=0;i<_count;i++)
            {
                Console.WriteLine(Array[i]+" ");
            }
            Console.WriteLine();
        }
        public void Remove(T value)
        {
            T[] temp = new T[_capacity*2];
            int j =0;
            for (int i =0;i<_count;i++)
            {
                if(value.Equals(Array[i]))
                {
                    i++;
                }
                temp[j]=Array[i];
                j++;
            }
            Array=temp;
            _count++;
        }
        public void RemoveAt(int index)
        {
            T[]temp = new T[_capacity*2];
            int j=0;
            for(int i=0;i<_count;i++)
            {
                if(i==index)
                {
                    i++;
                }
                temp[j]=Array[i];
                j++;
            }
            Array=temp;
            _count--;
        }
        public void Insert(int index,T item)
        {
            Console.WriteLine("Enter the element to be inserted:");
            
            T[]temp = new T[_capacity*2];
            for(int i =_capacity;i<index+1;i--)
            {
                Array[i]=Array[i-1];
            }
            Array[index-1]= item;
        }
    }

}