﻿using System;

namespace HashTableManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTableDS value = new HashTableDS(0);
            value.Add(1,"Suba");
            value.Add("Prasat","Usha");
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
   
