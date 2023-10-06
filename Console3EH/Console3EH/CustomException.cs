using System;

namespace Console3EH
{
    public class CustomException : Exception
    {
        public CustomException() : base() {
            Console.WriteLine("Inside custom exception");
        }

    }
}
