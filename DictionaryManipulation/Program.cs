using System;

namespace DictionaryManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryDS<int,string> value = new DictionaryDS<int, string>(0);
            value.Add(1,"Suba");
            value.Add(2,"Usha");
            value.Add(3,"Ravi");
            for (int i=0;i<value.Count;i++)
            {
                if(value!=null)
                {
                Console.WriteLine($"Key: {value[i].Key} \tValue: {value[i].Value}");
                }
            }
            foreach(var entry in value.Array)
            {
                if(entry!=null)
                {
                    Console.WriteLine($"Key: {entry.Key} \tValue: {entry.Value}");
                }
                 
            }
        }
    }

}
   
