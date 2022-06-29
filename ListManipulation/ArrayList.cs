using System;
namespace ListManipulation
{
    public class ArrayList<T>
    {
        private T [] Array{get; set;}
        private int _count;
        private int _capacity;
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

    }

}