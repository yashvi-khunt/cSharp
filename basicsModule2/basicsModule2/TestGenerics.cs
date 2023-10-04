using System;
    

namespace basicsModule2
{
    public class TestGenerics<T>
    {
        public void Add(T input) 
        {
            Console.WriteLine(input);
        }
    }
}
