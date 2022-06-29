namespace DictionaryManipulation
{
    public class DictionaryDS<TKey,TValue>:Dictionary<TKey,TValue>
    {
        public int Count=0;
        public int Capacity = 0;
        public Dictionary<TKey,TValue> []Array {get; set;}

        public DictionaryDS(int size)
        {
            if (size==0)
            {
                Capacity=3; 
                Count =0;
                Array = new Dictionary<TKey,TValue>[Capacity];
            }
            else if(size>0)
            {
                 Array = new Dictionary<TKey,TValue>[Capacity*2];
                 Capacity=Capacity*2;
                 Count=0;
            }
        }
        public Dictionary<TKey,TValue> this [int i]
        {
            get{
                return Array[i];
            }
        }
        public void Add(TKey key,TValue value)
        {   if (Capacity==Count)
            {
                Expand();
            } 
            Dictionary<TKey,TValue> entry = new Dictionary<TKey, TValue>();
            entry.Key = key;
            entry.Value = value;
            Array[Count]=entry;
            Count++;
        }
        public void Expand()
        {
            Dictionary<TKey,TValue> []temp = new Dictionary<TKey, TValue>[Capacity*2];
            for(int i = 0;i<Array.Length;i++)
            {
                temp[i]=Array[i];
            }
            Array=temp;
        }
    }
}