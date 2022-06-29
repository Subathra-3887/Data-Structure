using System;
namespace QueueManipulation
{
    public class Queue<T>
    {
        protected int Front;
        protected int Rear;
        protected int Size;
        public T[]Items;
        public Queue(int value)
        {
            Items = new T[value];
            Front=0;
            Rear = -1;
            Size =value;
        }
        public void Enqueue(T value)
        {
            ++Rear;
            if(Rear==Size)
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                Items[Rear]= value;
            }
        }
        public T Dequeue()
        {
            T value = default(T);
            if(Rear<Front)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine($"Output from the queue is {Items[Front]}");
                value = Items[Front];
                Front++;
            }
            return value;
        }

    }
}