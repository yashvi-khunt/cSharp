//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq.Expressions;

//namespace Console3EH
//{
//    public class CollectionClass
//    {
//        //public static void printMethod<T>(T a)
//        //{
//        //    var enumerable = a as System.Collections.IEnumerable;
//        //    if (enumerable != null)
//        //    {
//        //        foreach (var item in enumerable)
//        //        {
//        //            Console.WriteLine(item);
//        //        }
//        //    }
//        //}

//        public static void printMethod(IEnumerable myCollection)
//        {
//            foreach (Object obj in myCollection)
//                Console.Write("{0} ", obj);
//            Console.WriteLine();
//        }
//        public static void Main(string[] args)
//        {
//            //LIST :  used to store and fetch elements. It can have duplicate elements.

//            var animals = new List<string>();
//            animals.Add("Dog");
//            animals.Add("Cat");
//            animals.Add("Lion");
//            animals.Add("Tiger");
//            animals.Add("Cat");

//            printMethod(animals);

//            animals.Remove("Cat");
//            Console.WriteLine();
//            Console.WriteLine("After removing CAT");
//            printMethod(animals);
//            Console.WriteLine("Count : "+ animals.Count);

//            Console.WriteLine("\nWild Animals : ");
//            var WildAnimals = new List<string>() { "Lion", "Tiger" };
//            for (int i = 0; i < WildAnimals.Count; i++)
//            {
//                Console.WriteLine($"{WildAnimals[i]}");
//            }
//            Console.WriteLine("Count : " + WildAnimals.Count);

//            //HASHSET : HashSet class can be used to store, remove or view elements. It does not store duplicate elements
//            Console.WriteLine() ;
//            var domesticAnimals = new HashSet<string>();
//            Console.WriteLine("Adding cat 1st time :"+ domesticAnimals.Add("Cat"));
//            domesticAnimals.Add("Dog");
//            domesticAnimals.Add("Cow");
//            Console.WriteLine("Adding cat 2nd time :"+domesticAnimals.Add("Cat"));

//            Console.WriteLine("HashSet");
//            printMethod(domesticAnimals);
//            Console.WriteLine("Count : " + domesticAnimals.Count);

//            Console.WriteLine();
//            //SORTED SET : Used to store, remove or view elements. It maintains ascending order and does not store duplicate elements.
//            Console.WriteLine("SortedSet");
//            var farmAnimals = new SortedSet<string>();
//            farmAnimals.Add("Sheep");
//            farmAnimals.Add("Horse");
//            Console.WriteLine("Adding Cow 1st time :" + farmAnimals.Add("Cow"));
//            Console.WriteLine("Adding Cow 2nd time :" +farmAnimals.Add("Cow"));
//            printMethod(farmAnimals);
//            Console.WriteLine("Count : " + farmAnimals.Count);

//            //STACK : generic Stack<T> class stores elements using Push() method, removes elements using Pop() method and iterates elements using for-each loop.
//            Console.WriteLine();
//            Console.WriteLine("Stack : ");
//            Stack<string> names = new Stack<string>();
//            names.Push("abc");
//            names.Push("def");
//            names.Push("ghi");
//            names.Push("abc");

//            printMethod(names);
//            Console.WriteLine("Count : " + names.Count);
//            Console.WriteLine("Pop : "+ names.Pop());
//            Console.WriteLine("Count : " + names.Count);
//            printMethod(names);

//            Console.WriteLine("Peek : " + names.Peek());
//            names.Clear();
//            Console.WriteLine("Count : " + names.Count);
//            Console.Write("After clear: ");
//            printMethod(names);
//            //Console.Write("After clear: "+names.Peek());
//            Console.WriteLine(names.Contains("abc"));


//            /*  
//             * string str = "";
//             * names.TryPeek( out str); 
//             */

//            //QUEUE:  class that stores elements using Enqueue() method, removes elements using Dequeue() method and iterates elements using for-each loop.    --allows duplicates
//            Console.WriteLine();
//            Console.WriteLine("Queue");
//            Queue<String> numbers = new Queue<string>();
//            numbers.Enqueue("one");
//            numbers.Enqueue("two");
//            numbers.Enqueue("three");
//            numbers.Enqueue("three");

//            printMethod(numbers);
//            Console.WriteLine("Count : " + numbers.Count);
//            Console.WriteLine("Peek : "+ numbers.Peek());
//            Console.WriteLine("Dequeue : " + numbers.Dequeue());
//            Console.WriteLine("Count : " + numbers.Count);
//            Console.WriteLine("Peek : " + numbers.Peek());

//            Console.WriteLine("New Queue copied from existing queue: ");
//            Queue<string> queue2 = new Queue<string>(numbers);
//            printMethod(queue2);
//            queue2.Clear();
//            Console.WriteLine("Count : " + queue2.Count);

//            //LINKEDLIST 

//            var list = new LinkedList<string>();
//            Console.WriteLine();
//            Console.WriteLine("LinkedList : ");
//            list.AddFirst("one");
//            list.AddFirst("two");
//            list.AddLast("three");
//            list.AddLast("four");
//            printMethod(list);
//            Console.WriteLine("Count : "+ list.Count);

//            Console.WriteLine("Remove first from List");
//            list.RemoveFirst();
//            printMethod(list);
//            Console.WriteLine("Remove last from List");
//            list.RemoveLast();
//            printMethod(list);
//            Console.WriteLine("Remove element from List");
//            list.Remove("three");
//            printMethod(list);


//            //DICTIONARY 
//            var dict = new Dictionary<string, string>();
//            dict.Add("1", "one");
//            dict.Add("2", "two");
//            dict.Add("3", "three");
//            dict.Add("4", "three");
//            Console.WriteLine();
//            Console.WriteLine("Dictionary : ");
//            printMethod(dict);
//            dict["5"] = "five";
//            dict["4"] = "four";
//            Console.WriteLine("Print only keys");
//            printMethod(dict.Keys);
//            Console.WriteLine("Print only values");
//            printMethod(dict.Values);
//            dict.Remove("1");
//            printMethod(dict);
//            dict.Remove("7");        //Does not give any error
//            printMethod(dict);

//            //SORTED DICTIONARY
//            var sortedDict = new SortedDictionary<string, string>();
//            sortedDict.Add("one", "1");
//            sortedDict.Add("two", "2");
//            sortedDict.Add("three", "3");
//            sortedDict.Add("four", "4");
//            Console.WriteLine();
//            Console.WriteLine("Sorted Dict: ");
//            printMethod(sortedDict);

//            Console.WriteLine(sortedDict.ContainsKey("1"));
//            sortedDict.Remove("1");         //No error
//            sortedDict.Remove("one");
//            printMethod(sortedDict);

//            //SORTED LIST
//            var sortedList = new SortedList<string, string>();
//            sortedList.Add("one", "1");
//            sortedList.Add("two", "2");
//            sortedList.Add("three", "3");
//            Console.WriteLine();
//            Console.WriteLine("Sorted list: ");
//            printMethod(sortedList);

//        }
//    }
//}
