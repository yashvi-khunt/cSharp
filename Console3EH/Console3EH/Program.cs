//using System;
//namespace Console3EH
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            /*
//            int[] arr = { 1, 2, 3 };
//            GetInt(arr, 5);

//            void GetInt(int[] array, int index)
//            {
//                try
//                {
//                    Console.WriteLine(array[index]);
//                }
//                catch (IndexOutOfRangeException e)
//                {
//                    Console.WriteLine(e.Message);
//                }
//            }

//            Console.WriteLine("After 1st Exception.....");
//            */

//            /*
//            try
//            {


//                try
//                {

//                    Console.Write("Enter First Number : ");
//                    int fn = Convert.ToInt32(Console.ReadLine());

//                    Console.Write("Enter Second Number : ");
//                    int sn = Convert.ToInt32(Console.ReadLine());

//                    int result = fn / sn;
//                    Console.WriteLine($"result : {result}");
//                }
//                catch (DivideByZeroException ex)
//                {


//                        var y = 0;
//                        var result = 1 / y;


//             }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"ex.GetType : {ex.GetType()}");            //System.DivideByZero
//                Console.WriteLine($"ex.GetType.Name : {ex.GetType().Name}");       //DivideByZero
//                Console.WriteLine($"ex.GetType.Namespace : {ex.GetType().Namespace}");       //System
//                Console.WriteLine($"ex.Message : {ex.Message}");                //attempted to divide by zero
//                Console.WriteLine("Unexpected Error, Please try again.");
//            }

//            */

//            /*

//            try
//            {

//                int fn = 9;
//                int sn = 0;
//                int result = fn / sn;
//                Console.WriteLine($"result : {result}");
//            }
//            catch (DivideByZeroException ex)
//            {
//                Console.WriteLine($"ex.GetType : {ex.GetType()}");            //System.DivideByZero
//                Console.WriteLine($"ex.GetType.Name : {ex.GetType().Name}");       //DivideByZero
//                Console.WriteLine($"ex.GetType.Namespace : {ex.GetType().Namespace}");       //System
//                Console.WriteLine($"ex.Message : {ex.Message}");                //attempted to divide by zero
//                Console.WriteLine("Unexpected Error, Please try again.");

//                throw;
//                //Unhandled Exception: System.DivideByZeroException: Attempted to divide by zero. at
//                //Console3EH.Program.Main(String[] args) in D:\dotNet\Console3EH\Console3EH\Program.cs:line 86


//               // throw new DivideByZeroException("Cannot Divide by zero");
//                //Unhandled Exception: System.Exception: Attempted to divide by zero. at Console3EH.Program.Main(String[] args) in D:\dotNet\Console3EH\Console3EH\Program.cs:line 87
//            }
//            finally
//            {
//                Console.WriteLine("Complete Exception Handling");
//            }
//            */
//            try
//            {

//                int fn = 9;
//                int sn = 0;
//                if (sn == 0) { throw new CustomException(); }
//                int result = fn / sn;
//                Console.WriteLine($"result : {result}");
//            }
//            catch(CustomException ex) 
//            {
//                Console.WriteLine("Rest of the code");
//            }
//            Console.WriteLine();
//            Console.WriteLine("System Exception");
//            try
//            {
//                int[] arr = new int[5];
//                arr[10] = 25;
//            }
//            catch (SystemException e)
//            {
//                Console.WriteLine(e);
//            }

//            Checking c = new Checking();
//            c.uncheck();
//        }
//    }

//    public class Checking
//    {
//        public void uncheck()
//        {
//            int a = int.MaxValue;
//            Console.WriteLine(a);       //output: 2147483647
//            Console.WriteLine(a + 1);   // output: -2147483648            
//            //Console.WriteLine(a + 2);   //output: - 2147483647
//            //Console.WriteLine(a + 3);  // output: -2147483646
//            Console.WriteLine();
//            unchecked
//            {
//                Console.WriteLine("unchecked(a+2): "+ a + 2);    //output: - 2147483647     
//            }
//            Console.WriteLine();
//            checked
//            {
//                Console.WriteLine(a + 3);   //Error : OverFlowException
//            }
//        }
//}
//}

//Async-Await-Task
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Console3EH
{
    internal class Bacon { }
    internal class Coffee { }
    internal class Egg { }
    internal class Juice { }
    internal class Toast { }
    class Program
    {
        /*
        static void Main(string[] args) 
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            Egg eggs = FryEggs(2);
            Console.WriteLine("eggs are ready");

            Bacon bacon = FryBacon(3);
            Console.WriteLine("bacon is ready");

            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");

            Juice oj = PourOJ();
            Console.WriteLine("Orange juice is ready");
            Console.WriteLine("Breakfast is ready!");
        }

        static Juice PourOJ()
        {
            Console.WriteLine("Pouring Orange juice.");
            return new Juice();
        }

        static void ApplyJam(Toast toast)
        {
            Console.WriteLine("Putting jam on the toast");
        }

        static void ApplyButter(Toast toast)
        {
            Console.WriteLine("Putting butter on the toast");
        }

        static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        private static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }

        private static Egg FryEggs(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }
        */
        /*
        static async Task Main(string[] args)
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            var eggsTask = FryEggsAsync(2);
             var baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);

            var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
            while (breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);
                if (finishedTask == eggsTask)
                {
                    Console.WriteLine("eggs are ready");
                }
                else if (finishedTask == baconTask)
                {
                    Console.WriteLine("bacon is ready");
                }
                else if (finishedTask == toastTask)
                {
                    Console.WriteLine("toast is ready");
                }
                await finishedTask;
                breakfastTasks.Remove(finishedTask);
            }

            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");

            Console.ReadLine();
        }

        static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            Console.WriteLine("\tPutting jam on the toast");

        private static void ApplyButter(Toast toast) =>
            Console.WriteLine("\tPutting butter on the toast");

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("\tPutting a slice of bread in the toaster");
            }
            Console.WriteLine("\tStart toasting...");
            await Task.Delay(3000);
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            await Task.Delay(3000);
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            await Task.Delay(3000);                                 
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            await Task.Delay(3000);
            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }*/

        static async Task bait(int i)
        {
            await Task.Delay(1000);
            Console.WriteLine("Task fun" + i);
        }
        static async Task wait(int i)
        {
            await Task.Delay(1000);
            Console.WriteLine("Task fun" + i);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("before func call");

            var t = wait(1);

            Console.WriteLine("after func call");
             wait(2);
            //await Task.Delay(2000);
             //t.Start();
            Console.WriteLine("after await wait(2)");
            var client = new HttpClient();

            //Task<string> getStringTask =
            var t2 = client.GetStringAsync("https://learn.microsoft.com/dotnet");
            Console.WriteLine(t2.Result);
            Console.ReadLine();
        }
    }

    /*
    public static void Main(string[] args)
    {

        var obj = new Method();
        CallBack d1 = obj.Method1;
        CallBack d2 = obj.Method2;
        CallBack handler = DelegateMethod;
        //handler("hello");
        CallBack AllMethodsDelegate = d1+d2;
        AllMethodsDelegate += handler;
        //MethodWithCallBack("1", "2", handler);
        AllMethodsDelegate.Invoke("hello");
    }
    public delegate void CallBack(string message);

    public static void DelegateMethod(string message) 
    {
        Console.WriteLine(message + " - delegate method"); 
    }

    //public static void MethodWithCallBack(string par1,string par2, CallBack callback) 
    //{
    //    callback("This num is " + par1 + par2);
    //}
}


public class Method
{
    public void Method1(string message)
    {
        Console.WriteLine(message + " - method1");
    }
    public void Method2(string message)
    {
        Console.WriteLine(message + " - method2");
    }
}*/
}

