namespace HashTableManipulation
{
    public class HashTableDS:ObjectArray
    {
        public int Count;
        public int Capacity ;
        public ObjectArray [] Array {get; set;}

        public HashTableDS(int size)
        {
            if (size==0)
            {
                Capacity=3; 
                Count =0;
                Array = new ObjectArray[Capacity] ;
            }
            else if(size>0)
            {
                 Array = new ObjectArray[Capacity*2];
                 Capacity=Capacity*2;
                 Count=0;
            }
        }
        public ObjectArray this [int i]
        {
            get
            {
                return Array[i];
            }
        }
        public void Add(object key,object value)
        {   if (Capacity==Count)
            {
                Expand();
            } 
            ObjectArray entry = new ObjectArray();
            entry.Key = key;
            entry.Value = value;
            Array[Count]=entry;
            Count++;
        }
        public void Expand()
        {
            ObjectArray []temp = new ObjectArray[Capacity*2];
            for(int i = 0;i<Array.Length;i++)
            {
                temp[i]=Array[i];
            }
            Array=temp;
        }
    }
}