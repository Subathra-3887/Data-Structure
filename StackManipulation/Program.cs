using System;

namespace StackManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
           Stack<int> value = new Stack<int>(5);
            value.Push(12);
            value.Push(13);
            value.Push(54);
            value.PrintStack();
            Console.WriteLine($" Value popped out is: {value.Pop()}");

            Stack<char> a = new Stack<char>(5);
            a.Push('a');
            a.Push('b');
            a.Push('m');
            a.PrintStack();
            Console.WriteLine($"Value popped out is: {a.Pop()}");
            Console.WriteLine($"Value popped out is: {a.Pop()}");
        }
    }

}
   
