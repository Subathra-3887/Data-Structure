using System.Collections;
namespace ListManipulationAssignment
{
    public partial class ArrayList<T>:IEnumerable,IEnumerator
    {
        private int Position = -1;
        public IEnumerator GetEnumerator()
        {
            return(IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(Position<Array.Length-1)
            {
                ++Position;
                return true;
            }
            return false;
        }
        public void Reset()
        {
            Position=-1;
        }
        public object Current
        {
            get
            {
                return Array[Position];
            }
        }
    }
}