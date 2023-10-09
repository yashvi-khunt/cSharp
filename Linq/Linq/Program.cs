using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Data source
            int[] scores = { 56, 76, 34, 75, 80, 65 };

            //Query creation 
            IEnumerable<int> scoreQuery = 
                from score in scores
                where score > 70
                select score;

            Console.WriteLine(scoreQuery.GetType());
            //query execution
            foreach (var item in scoreQuery)
            {
                 Console.WriteLine(item);
            }


            string sentence = "the quick brown fox jumps over the lazy dog";

            string[] words = sentence.Split(' ');

            //QUERY EXPRESSION
            var query = from word in words
                        group word by word.Length into grp
                        orderby grp.Key
                        select new { Length = grp.Key, Words = grp };


            //METHOD BASED QUERY SYNTAX
            Console.WriteLine("method base query expression : ");
            var query2 = words
                .GroupBy(w => w.Length)
                .Select(g => new {Length = g.Key, Words = g })
                .OrderBy(o => o.Length);

            //Print results
            foreach(var q in query2 )
            {
                Console.Write($"Words of length {q.Length} : ");
                foreach (var word in q.Words)
                {
                    Console.Write(" " + word);
                }
                Console.WriteLine();
            }



            Console.WriteLine("query expression : ");
            foreach (var q in query)
            {
                Console.Write($"Words of length {q.Length} : ");
                foreach(var word in q.Words)
                {
                    Console.Write(" "+word);
                }
                Console.WriteLine();
            }

            List<int> integerList = new List<int>() { 1,2,3,4,5,6,7,8,9};

            var combineSyntax = (from objInt in integerList
                                where objInt > 5
                                select objInt).Sum();

            Console.WriteLine("Sum is : " + combineSyntax);


            List<string> countries = new List<string>() { "India","USA","Australia","Russia" };

            var result = countries.Select(x => x);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            int min = integerList.Min();
            Console.WriteLine("Min: " + min);

            int max = integerList.Max();
            Console.WriteLine("Max: " + max);
            
            int sum = integerList.Sum();
            Console.WriteLine("Sum: " + sum);

            int count = integerList.Count();
            Console.WriteLine("Count: " + count);


            int sumAgg = integerList.Aggregate((a, b) => a + b);
            Console.WriteLine("sumAgg: " + sumAgg);

            string[] charList = { "h", "e", "l", "l", "o" };
            var concat = charList.Aggregate((a, b) => a + b);
            Console.WriteLine("concatAgg: "+ concat);


            //sorting operator
            List<Student> objStu = new List<Student>()
            {
                 new Student() { Name = "Praveen Kumar", Gender = "Male", Subjects = new List<string> { "Computers", "Operating System", "Java" } },
                new Student() { Name = "Praveen Kumar", Gender = "Female", Subjects = new List<string> { "Mathematics", "Physics" } },
                new Student() { Name = "Madhav Sai", Gender = "Male", Subjects = new List<string> { "Accounting", "Charted" } },
                new Student() { Name = "Rohini Alavala", Gender = "Female", Subjects = new List<string> { "Entomology", "Botany" } }
            };

            Console.WriteLine("order by, Then by descending operator :");

            var studentName = objStu.OrderBy(x => x.Name).ThenByDescending(x => x.Gender);
            foreach (var student in studentName)
            {
                Console.WriteLine(student.Name + " " + student.Gender);
            }

            Console.WriteLine("order by descending," +
                "Then by  operator :");

             studentName = objStu.OrderByDescending(x => x.Name).ThenBy(x => x.Gender);
            foreach (var student in studentName)  
            {
                Console.WriteLine(student.Name +" "+ student.Gender);
            }


            //Partition operators

            countries.Add("UK");
            countries.Add("Japan");
            Console.WriteLine("Take Method syntax: ");
            IEnumerable<string> takeResultMethod = countries.Take(3);
            foreach (string s in takeResultMethod) 
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Take Query syntax: ");
            IEnumerable<string> takeResultQuery = (from x in countries select x).Take(3);
            foreach (string s in takeResultQuery)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Take While Method : ");
            IEnumerable<string> takeWhileMethod = countries.TakeWhile(x => x.StartsWith("I"));

            foreach (string s in takeWhileMethod)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Take While Query");
            IEnumerable<string> takeWhileQuery = (from x in countries select x).TakeWhile(x => x.StartsWith("I"));
            foreach (string s in takeWhileQuery)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Skip Method :");
            var skipMethod = countries.Skip(2);
            foreach (string s in skipMethod)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Skip Query : ");
            var skipQuery = (from x in countries select x).Skip(2);
            foreach (string s in skipQuery)
            {
                Console.WriteLine(s);
            }

            //CONVERSION OPERATORS 
            string[] statesArr = { "Gujarat", "Rajasthan", "Maharashtra", "Tamil Nadu","West Bengal","Madhya Pradesh"};

            Console.WriteLine("Type of statesArr : "+ statesArr.GetType().Name);

            var statesListM = statesArr.ToList();
            Console.WriteLine("Type of statesListM : " + statesListM.GetType().Name);


            var statesListQ = (from x in statesListM select x).ToList();
            Console.WriteLine("Type of statesListQ : " + statesListQ.GetType().Name);


            var statesArrM = statesListM.ToArray();
            Console.WriteLine("Type of statesArrM : " + statesArrM.GetType().Name);

            var statesArrQ = (from x in statesListQ select x).ToArray();
            Console.WriteLine("Type of statesArrQ : " + statesArrQ.GetType().Name);


            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ Name="Akshay Tyagi", Department="IT", Country="India"},
                new Employee(){ Name="Vaishali Tyagi", Department="Marketing", Country="Australia"},
                new Employee(){ Name="Arpita Rai", Department="HR", Country="China"},
                new Employee(){ Name="Shubham Ratogi", Department="Sales", Country="USA"},
                new Employee(){ Name="Himanshu Tyagi", Department="Operations", Country="Canada"}

            };

            foreach(var employee in employees)
            {
                Console.WriteLine($"{employee.Name} - {employee.Department} - {employee.Country}");
            }


            Console.WriteLine("Look up - groupin employees by department : ");

            var empM = employees.ToLookup(x => x.Department);

            foreach(var employee in empM)
            {
                Console.WriteLine(employee.Key);

                foreach(var i in empM[employee.Key])
                {
                    Console.WriteLine("\t" + i.Name + "\t" + i.Department + "\t" + i.Country);
                }
            }
            Console.WriteLine("Cast: ");
            ArrayList obj = new ArrayList();
            obj.Add("India");
            obj.Add("USA");
            obj.Add("Australia");
            Console.WriteLine("Type of obj : " + obj.GetType().Name);

            var res = obj.Cast<string>();
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Type of obj : " + res.GetType().Name);


            Console.WriteLine("Of Type : ");
            obj.Add(1);
            obj.Add(2);

            var typeOfRes = obj.OfType<int>();

            foreach (var item in typeOfRes)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("TO dictionary: ");

            List<Student1> objStudent = new List<Student1>()
            {
                new Student1() { Id=1,Name = "Vinay Tyagi", Gender = "Male",Location="Chennai" },
                new Student1() { Id=2,Name = "Vaishali Tyagi", Gender = "Female", Location="Chennai" },
                new Student1() { Id=3,Name = "Montu Tyagi", Gender = "Male",Location="Bangalore" },
                new Student1() { Id=4,Name = "Akshay Tyagi", Gender = "Male", Location ="Vizag"},
                new Student1() { Id=5,Name = "Arpita Rai", Gender = "Male", Location="Nagpur"}
            };

            var students = objStudent.ToDictionary(x=>x.Id, x=>x.Name);

            foreach (var stu in students)
            {
                Console.WriteLine(stu.Key + " "+ stu.Value);
            }


            //ELEMENT OPERATORS 

            Console.WriteLine("FirstM() : "+integerList.First());
            Console.WriteLine("FirstQ() : " + (from x in integerList select x).First());

            int[] integerArr = { };
            string[] stringArr = { };

            //Console.Write(integerArr.First());   --gives error because there is no element in array

            Console.WriteLine("FirstorDefaultM() : " + integerArr.FirstOrDefault());
            Console.WriteLine("FirstorDefaultQ : " + (from x in stringArr select x).FirstOrDefault());

            Console.WriteLine("LastM() : " + integerList.Last());
            Console.WriteLine("LastQ() : " + (from x in integerList select x).Last());

            Console.WriteLine("LastorDefaultM() : " + integerArr.LastOrDefault());
            Console.WriteLine("LastorDefaultQ : " + (from x in stringArr select x).LastOrDefault());


            Console.WriteLine("ElementAt(2)M : "+ integerList.ElementAt(2));
            Console.WriteLine("ElementAt(2)Q : " + (from x in integerList select x).ElementAt(2));


            Console.WriteLine("ElementAtOrDefault(2)M : " + integerArr.ElementAtOrDefault(2));
            Console.WriteLine("ElementAtOrDefault(2)Q : " + (from x in stringArr select x).ElementAtOrDefault(2));

            Console.WriteLine("Single : ");
            var user = objStu.Single(s => s.Name == "Madhav Sai");
            //var user = objStu.Single(s => s.Name == "Praveen Kumar");  -- gives error as it finds multiple values
            Console.WriteLine(user.Name +" "+ user.Gender);


            //user = objStu.SingleOrDefault(s => s.Name == "Praveen Kumar");      --gives error as it finds multiple values
            var exmp = integerArr.SingleOrDefault();
            Console.WriteLine(exmp);


            Console.WriteLine("DefaultEmplty() : ");
            Console.Write("With values :");
            foreach(var item in integerList.DefaultIfEmpty())
            {
                Console.Write(item+" ");
            }

            Console.Write("\nWithout values :");
            foreach (var item in integerArr.DefaultIfEmpty())
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }

    public class Student
    {
        private string _name;
        private string _gender;
        private List<string> _subjects;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }

        }
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }

        public List<string> Subjects
        {
            get
            {
                return _subjects;
            }
            set 
            { 
                _subjects = value; 
            }
        }
    }

    public class Employee
    {
        private string _name;
        private string _department;
        private string _country;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
    }

    public class Student1
    {
        private int _id;
        private string _name;
        private string _gender;
        private string _location;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
    }
}
