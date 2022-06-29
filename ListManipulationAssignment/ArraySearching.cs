using System;
namespace ListManipulationAssignment
{
    public partial class ArrayList<T>
    {
        public void LinearSearch(T value)
        {
            bool type = false;
            for(int i = 0;i<_count;i++)
            {
                if(value.Equals(Array[i]))
                {
                    type = true;
                    Console.WriteLine($"The value if found at position: {i}");
                }
                else if(!type)
                {
                    Console.WriteLine("The value is not present in the array");
                }
            }
        }
    }
}