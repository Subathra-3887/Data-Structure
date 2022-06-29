namespace ArrayListManipulation
{
    public class ArrayList
    {
        public object [] Array { get; set; }
        private int _count;
        private int _capacity;
        public int Capacity { get{return _capacity;} }
        public int Count { get{return _count;}}
        
        public object this[int i]
        {
            get{return Array[i];}
        }
        public ArrayList (int size)
        {
            if(_capacity==0 || size<0)
            {
                Array = new object[5];
                _capacity=5;
                _count=0;
            }
            else
            {
                Array = new object[size*2];
                _capacity=size*2;
                _count=0;
            }
        }
        public void Add(object value)
        {
            if(_count==_capacity)
            {
                Expand();
            }
            Array[_count] = value;
            _count++;
            
        }
        public void Expand()
        {
            object[] temp = new object[_capacity*2];
            for(int i =0;i<_count;i++)
            {
                temp[i] = Array[i];
            }
            Array=temp;
            _capacity=_capacity*2;
        }
        public void Display()
        {

        }
        
        
    }
}