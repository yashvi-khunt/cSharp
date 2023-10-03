using System;
using Second;
namespace basicsModule2
{

    public class Program
    {
       public static void Main(string[] args)
        {
            /*
            //abstraction
            //AbstractExample example = new AbstractExample();   //ERROR: cannot create instance of abstract type or interface AbstractExample  

            AbstractExample s = new Square();
            s.setDetails(4, "BLue");
            s.getDetails();
            s.draw();
            s = new Circle();
            s.setDetails(0, "Red");
            s.getDetails();
            s.draw();
            */

            /*
            //Interface
            InterfaceExample e = new InterfaceExample();
            e.sampleMethod();
            e.sampleMethod2();

            MultipleInterface mi = new MultipleInterface();
            mi.printName();
            mi.printAge();

            //IStudent s = new IStudent();  //ERROR: Cannot create an instance of the abstract type or interface 'IStudent'

            IStudent s = new MultipleInterface();
            s.printName();
            //s.printAge();  //s is of type IStudent which has only PrintName Method so S.printAge gives error
            */
            /*
            //NameSpace
            First.Hello h1 = new First.Hello();
            h1.sayHello();

            Hello h2 = new Hello();
            h2.sayHello();

            */

            //properties
            Properties p = new Properties();
            p.Name = "Test";
            //p._name = "Test2";  //if _name is not private - it will set to Test2
            p.printName();
            Grand g1 = new Grand();
            g1.draw();
            Console.ReadLine();
        }
    }
    public class Base
    {
        public virtual void draw()
        {
            Console.WriteLine("HEllo Base");
        }
    }
    public class Derived : Base
    {
        public  override void draw()
        {
            Console.WriteLine("HEllo derived");
            base.draw();
        }
    }
    public class Grand : Derived
    {
        public override void draw()
        {
            base.draw();
        }
    }
    //creating an object student
    /*
    public class Student
    {
        int id;
        String name;

        public static void Main(string[] args)
        {
            Student s = new Student();
            s.id = 101;
            s.name = "test";

            Console.WriteLine(s.id);
            Console.WriteLine(s.name);

        }
    }*/

    // Having Main() in another class
    /*
    public class Student
    {
        public int id;
        public string name; 
    }
     class TestStudent
    {
        //int id;         //instance variable
        //String name;        //instance variable
    
        public static void Main(string[] args)
        {
            Student s = new Student();
            s.id = 101;
            s.name = "test";
            Console.WriteLine(s.id);
            Console.WriteLine(s.name);
        }
    }*/

    //Initialize and Display data through method
    /*
   public class Student
   {    
       public int id;
       public string name;
       public void insert(int i, String s)
       {
           id = i;
           name = s;
       }

       public void display()
       {
           Console.WriteLine(id+ " " + name);
       }
       //constructor
       public Student()
       {
           Console.WriteLine("Student constructor");
       }
   }

   class TestStudent
   {
       public static void Main(string[] args)
       {
           Student s1 = new Student();
           s1.id = 101;
           s1.name = "Test";
           Student s2 = new Student();
           s2.insert(102, "Test2");
           s1.display();
           s2.display();
       }
   }*/
    /*
    //constructor
    public class Employee
    {
        //constructor for public class
        public Employee() 
        {
            Console.WriteLine("Default Constructor");

        }
        public static void Main(string[] args)
        {
            Employee e = new Employee();
            Student s = new Student();
        }
    }
    */

    /*
    //Parameterized constructor
    //destructor
    class Employee
    {
        public int id;
        public string name;

        //parametrized constructor
        public Employee(int i, String n) 
        {
            id = i;
            name = n;
        }

        //destructor
        ~Employee()
        {
            Console.WriteLine("Destructor invoked");
        }

        public void display()
        {
            Console.WriteLine(id+" "+name);
        }
    }

    class TestEmployee
    {
        public static void Main(string[] args)
        {
            Employee e = new Employee(101,"abc");
            e.display();
        }
    }*/

    /*
     
    //this keyword
    public class Employee
    {
        public int id;
        public string name;
        public int age;

        public Employee(int id, String name, int age) 
        {
            this.id = id;
            this.name = name;  
            this.age = age;
        }

        public void display()
        {
            Console.WriteLine(id + " " + name);
            TestEmployee.printAge(this);  //passing this as parameter
        }
    }

    public class TestEmployee
    {

        public static void printAge(Employee e)
        {
            Console.WriteLine("Age: " + e.age);
        }
        public static void Main(string[] args)
        {
            Employee e = new Employee(101,"abc",23);
            e.display();
        }
    }
    */
    //static
    /*
    public class Employee
    {
        public int id;
        public string name;
        public static string department = "Management";

        public Employee(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine(id + " " + name+" : "+department);
           
        }
    }

    public class TestEmployee
    {
        public static void Main(string[] args)
        {
            
            Employee e = new Employee(101, "abc");
            e.display();

            Employee.department = "HR";
            e.display();
        }
    }*/
    /*
    static class School
    {
        int a;  // gives error
        static int b;
    }
    */
    /*
    //structs
     struct  Student
    {
        public int id;
        public string name;

        public void display() 
        {
            Console.WriteLine(id + " " + name);
        }
    }

    public class ClassRoom
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
            s.id = 1;
            s.name = "test";
            s.display();

            Student s2 = s;
            s2.display();
            s2.id = 2;
            s2.display() ;
            s.display() ;
        }
    }
    */



    /*
    //enum
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    public class EnumDemo
    {
        public static void Main(string[] args)
        {
            Season s = Season.Spring;
            Console.WriteLine(s + " " + (int)s);

            Season s2 = (Season)0;
            Console.WriteLine(s2 + " " + (int)s2);

            Season s3 = (Season)4;
            Console.WriteLine(s3 + " " + (int)s3);
        }   
    }
    */

    /*
    //inheritance

    public class Animal
    {
        public string type = "Animal";
    }

    public class Dog: Animal    //single level inheritance
    {
        public string name = "dog";
    }

    public class Breed : Dog
    {
        public string breed = "beagle";
    }

    public class Cat: Animal
    {
        public string name = "cat";
    }

    public class TestAnimal
    {
    public static void Main(string[] args)
        {
            Animal a = new Animal();
            Console.WriteLine(a.type);
            Dog d = new Dog();
            Console.WriteLine(d.type+" > " + d.name);
            Cat c = new Cat();
            Console.WriteLine( c.type + " > " + c.name);
            Breed b = new Breed();
            Console.WriteLine( b.type + " > " + b.name + " > " + b.breed );
        }

    }
    */


    //aggregation
    /*
    public class Address
    {
        public string addressLine, city, state;
        public Address(string addressLine, string city, string state)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
        }
    }
    public class Employee
    {
        public int id;
        public string name;
        public Address address;//Employee HAS-A Address  
        //public Employee(int id, string name, Address address)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.address = address;
        //}

        public void createEmployee(int id,string name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " +
              address.addressLine + " " + address.city + " " + address.state);
        }
    }
    public class TestAggregation
    {
        public static void Main(string[] args)
        {
            Address a1 = new Address("G-13, Sec-3", "Noida", "UP");
            Employee e1 = new Employee();
            e1.createEmployee(1, "Sonoo",a1);
            e1.display();
        }
    }*/

    /*
    public class Shapes
    {

       public int area(int a,int b)
        {
            return a * b;
        }

        //public int area(int b, int a)   //Error: 'Shapes' already defines a member called 'area'                                   with the same parameter types basicsModule2 * 
        //{
        //    return b * a;
        //}

        public int area(string a,string b)
        {
            return int.Parse(a) + int.Parse(b);
        }

        public int area(int a,int b, int c)
        {
            return a * b * c;
        }
        //public float area(int af, int bf)   //Error: 'Shapes' already defines a member called '                                        area' with the same parameter types basicsModule2

        //{
        //    return (int)(af * bf);
        //}
        public int area(float af,float bf) 
        { 
            return (int)(af * bf); 
        }
    }*/



    /* overriding 
    public class Animal{  
        public virtual void eat(){  
            Console.WriteLine("Eating...");  

        }
    }  
    public class Dog: Animal  
    {  
        public override void eat()  
        {  
            Console.WriteLine("Dog Eating bread...");  
        }  
    }
    public class Cat : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Cat Eating bread...");
        }
    }

    public class TestOverriding  
    {  
        public static void Main()  
        {  
            Animal d = new Dog();  
            d.eat();  
            d = new Cat();
            d.eat();
        }  
    }  
    */

    /*
    //base
    class TestOverride
    {
        public class Employee
        {
            public string Name { get; }

            // Basepay is defined as protected, so that it may be
            // accessed only by this class and derived classes.
            protected decimal _basepay;

            // Constructor to set the name and basepay values.
            public Employee(string name, decimal basepay)
            {
                Name = name;
                _basepay = basepay;
            }

            // Declared virtual so it can be overridden.
            public virtual decimal CalculatePay()
            {
                return _basepay;
            }
        }

        // Derive a new class from Employee.
        public class SalesEmployee : Employee
        {
            // New field that will affect the base pay.
            private decimal _salesbonus;

            // The constructor calls the base-class version, and
            // initializes the salesbonus field.
            public SalesEmployee(string name, decimal basepay, decimal salesbonus)
                : base(name, basepay)
            {
                _salesbonus = salesbonus;
            }

            // Override the CalculatePay method
            // to take bonus into account.
            public override decimal CalculatePay()
            {
                return _basepay + _salesbonus;
            }
        }

       

        static void Main()
        {
            // Create some new employees.
            var employee1 = new SalesEmployee("Alice", 1000, 500);
            var employee2 = new Employee("Bob", 1200);

            Console.WriteLine($"Employee1 {employee1.Name} earned: {employee1.CalculatePay()}");
            Console.WriteLine($"Employee2 {employee2.Name} earned: {employee2.CalculatePay()}");
        }
    }
    */

    /*
    sealed public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Animal eating...");
        }
    }

    public class Dog : Animal                   //ERROR -  'Dog': cannot derive from sealed type 'Animal'
    {
        public void eat()
        {
            Console.WriteLine("Dog eating....");
        }
    }

    public class TestSealed
    {
        public static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.eat();
            Dog dog = new Dog();
            dog.eat();
        }
    }

    */

}


