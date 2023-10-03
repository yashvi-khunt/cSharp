using System;

namespace basicsModule2
{
    public class Properties
    {
        private string _name;
        public string Name
        {
            get => _name ?? "NULL";
            set => _name = value;
        }

        public void printName() 
        {
            Console.WriteLine($"Name : {Name} ");
        }
    }
}
