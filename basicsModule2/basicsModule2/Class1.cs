using System;

namespace First
{
    public class Hello
    {
        public void sayHello()
        {
            Console.WriteLine("Hello from First");
        }
    }
}

namespace Second
{
    public class Hello
    {
        public void sayHello() 
        {
            Console.WriteLine("Hello from second");
        }
    }
}
namespace basicsModule2
{
    
    interface ICustomer
    {
        void sampleMethod();
    }

    interface ICustomer2 
    {
        void sampleMethod2();
    }

    public class InterfaceExample: ICustomer, ICustomer2  //inheriting multiple interfaces
    {
        public void sampleMethod() 
        {
            Console.WriteLine("Implementing interface");
        }

        public void sampleMethod2()
        {
            Console.WriteLine("Implementing interface2");
        }
    }

    interface IStudent
    {
        void printName();
    }
    interface IStudent1 : IStudent
    {
        void printAge();
    }

    public class MultipleInterface : IStudent1
    {
        public void printName() 
        {
            Console.WriteLine("Name of Student");
        }

        public void printAge()
        {
            Console.WriteLine("Age of Student");
        }
    }
}
