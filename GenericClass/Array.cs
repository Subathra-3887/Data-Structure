namespace GenericClass
{
    public class Array<Type>
    {
        public Type [] ArrayInfo { get; set; }

        public Type this [int i]   //Indexers
        { 
            get
            {
                return ArrayInfo[i];
            } 
            set
            {
                ArrayInfo[i]=value; 
            }

        }
    }
}