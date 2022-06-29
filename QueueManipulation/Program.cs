using System;

namespace QueueManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue <int> q = new Queue<int>(10);
            for(int i =0;i<q.Items.Length;i++)
            {
                Console.WriteLine($"Enter the {i} value");
                q.Enqueue(Convert.ToInt16(Console.ReadLine()));
            }
            Console.WriteLine("Values in the queue:");
            foreach(int value in q.Items)
            {
                Console.WriteLine(value+ " ");
            }
            q.Dequeue();
            
        }
    }

}
   
