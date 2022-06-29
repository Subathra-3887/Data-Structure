using System;
namespace StackManipulation
{
    public class Stack <T>
    {
        private T[] Element;
        private int top;
        private int max;
        public Stack(int size)
        {
            Element = new T[size];
            top =-1;
            max = size;
        }
        public void Push (T item)
        {
            if(top == max-1)
            {
                Console.WriteLine("Stack Overflow");
            }
            else 
            {
                Element[++top] =item;
            }
            
        }
        public T Pop()
        {
            T value = default(T);
            if(top !=1)
            {
                Console.WriteLine($"{Element[top]} popped from stack");
                value = Element[top];
                top--;
            }
            else if(top ==-1)
            {
                Console.WriteLine("Stack is Empty");
            }
            return value;
        }
        public void PrintStack()
        {
            if(top>=0)
            {
                for(int i=0;i<top;i++)
                {
                    Console.WriteLine($"Element {Element[i]} is at position {i}");
                }
            }
        }
    }
}