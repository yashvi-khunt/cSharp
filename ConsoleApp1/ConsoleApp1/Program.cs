using System;

namespace ConsoleApp1
{
     class Program
    {
        static void Show(params object[] val)
        {
            for(int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }

        static void printArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void ArrayMethod()
        {

            //single dimentional
            int[] EvenNums = new int[3] {2,4,6};
            Console.WriteLine("Single DImentional Array");
            Console.WriteLine(EvenNums[0]);
            Console.WriteLine(EvenNums[1]);
            Console.WriteLine(EvenNums[2]);

            //passin array to function
            Console.WriteLine("Passing array to a function.");
            printArray(EvenNums);


            //multiDimentional Array
            Console.WriteLine("Multidimentional array");
            Console.WriteLine("2D");
            int[,] twoD = new int[3,3];
            int[,] twoDimentional = new int[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };
            twoD[0, 1] = 10;
            twoD[1, 2] = 20;
            twoD[2, 0] = 30;   

            for(int i = 0; i < 3; i++)
            {
                for (int j = 0;j < 3; j++)
                {
                    Console.Write(twoD[i, j] + " ");
                }
                Console.WriteLine();
            }

            //jagged array
            Console.WriteLine("jagged Array");
            int[][] j_arr = new int[3][]{
                                new int[] { 11, 21, 56, 78 },
                                new int[] { 2, 5, 6, 7, 98, 5 },
                                new int[] { 2, 5 }
                            };
            for (int i = 0; i < j_arr.Length; i++)
            {
                for (int j = 0; j < j_arr[i].Length; j++)
                {
                    System.Console.Write(j_arr[i][j] + " ");
                }
                System.Console.WriteLine();
            }
            int[] arr = { 3, 8, 5, 6, 3, 5, 7, 2 };
            Console.WriteLine("Param : ");
            Show("Ramakrishnan Ayyer", "Ramesh", 101, 20.50, "Peter", 'A');

            Console.WriteLine("length of first array: " + arr.Length);
            Array.Sort(arr);
            Console.WriteLine("Sorted array: ");
            printArray(arr);

            Console.WriteLine("Index position of 4 is" + Array.IndexOf(arr, 4));
            int[] arr2 = new int[arr.Length];
            Array.Copy(arr, arr2, arr.Length);
            Console.WriteLine("SEcond Array elements : ");
            printArray(arr2);

            Array.Reverse(arr2);
            Console.WriteLine("reversed array :");
            printArray(arr2 );


        }

        static void Exercise1() 
        {
            Console.WriteLine("Enter a number for loop: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int temp = 65;
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write(Convert.ToChar(temp));
                    if (j < i)
                    {
                        temp++;
                        if (temp > 90)
                        {
                            temp = 65;
                        }
                    }
                    else
                    {
                        temp--;
                        if (temp < 65)
                        {
                            temp = 90;
                        }
                    }


                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Introduction:");
            //int a = 10;
            //int b = 20;
            //int total = a + b;
            //Console.Write("Total: {0} + {1} = {2}",a,b,total);


            ////if statement
            //Console.WriteLine("\nIf-statement: ");
            //int num = 10;
            //if(num % 2 == 0)
            //{
            //    Console.WriteLine("{0} is Even Number", num);
            //}


            ////if-else statement
            //Console.WriteLine("\nIf-Else Statement: ");
            //num = 11;
            //if(num % 2 == 0)
            //{
            //    Console.WriteLine("{0} is Even Number", num);
            //}
            //else
            //{

            //    Console.WriteLine("{0} is Odd Number", num);
            //}


            ////if else using user input
            //Console.WriteLine("Enter a number(1-100):");
            //num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Else if :");
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("{0} is a even number", num);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is Odd Number", num);
            //}


            ////else if ladder
            //Console.WriteLine("Else if ladder :");

            //if (num >= 0 && num < 50)
            //{
            //    Console.WriteLine("Fail");
            //}
            //else if (num >= 50 && num < 60)
            //{
            //    Console.WriteLine("D Grade");
            //}
            //else if (num >= 60 && num < 70)
            //{
            //    Console.WriteLine("C Grade");
            //}
            //else if (num >= 70 && num < 80)
            //{
            //    Console.WriteLine("B Grade");
            //}
            //else if (num >= 80 && num < 90)
            //{
            //    Console.WriteLine("A Grade");
            //}
            //else if (num >= 90 && num <= 100)
            //{
            //    Console.WriteLine("A+ Grade");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong input");
            //}


            ////switch case
            //Console.WriteLine("Switch case for entered number:");
            //switch (num)
            //{
            //    case 10: 
            //        Console.WriteLine("It is 10");
            //        break;
            //    case 20: 
            //        Console.WriteLine("It is 20");
            //        break;
            //    case 30: 
            //        Console.WriteLine("It is 30");
            //        break;
            //    default: 
            //        Console.WriteLine("Not 10,20,30");
            //        break;
            //}


            ////for loop
            //Console.WriteLine("For loop:");

            //for(int i = 0;i < 10; i++)
            //{
            //   Console.WriteLine(i);
            //}


            ////nested loop
            //Console.WriteLine("Nested For loop:");

            //for (int i = 1; i < 3; i++)
            //{
            //    for(int j = 1; j < 3; j++)
            //    {
            //        Console.WriteLine(i+" "+j);
            //    }
            //}



            ////infinite for loop
            ///*for(; ; )
            //{
            //    Console.WriteLine("Infinite loop");
            //}*/


            ////while loop
            //Console.WriteLine("While Loop");
            //int k = 1;
            //while(k < 4) 
            //{
            //    Console.WriteLine(k);
            //    k++;
            //}


            ////nested while loop
            //Console.WriteLine("Nested while loop");
            //k = 1;
            //while(k < 4)
            //{
            //    int i = 1;
            //    while (i < 4)
            //    {
            //        Console.WriteLine(i+" "+k);
            //        i++;
            //    }
            //    k++;
            //}


            ////infinite while loop
            ///*
            // while(true)
            //{
            //    Console.WriteLine("Infinite While Loop");
            //}
            // */

            ////do-while loop
            //Console.WriteLine("Do while loop");
            //k = 1;
            //do
            //{
            //    Console.WriteLine(k);
            //    k++;
            //} while (k < 4);


            ////do while nested loop
            //Console.WriteLine("Nested do while loop");
            //k = 1;
            //do
            //{
            //    int i = 1;
            //    do
            //    {
            //        Console.WriteLine(i + " " + k);
            //        i++;
            //    } while (i < 4);

            //    k++;
            //}while (k < 4);

            ////infinite do while
            ///*do
            //{
            //    Console.WriteLine("Infinite do while loop");
            //} while (true);
            //*/


            ////break statement
            //Console.WriteLine("Break");
            //for (int i = 1;i < 3; i++)
            //{
            //    Console.WriteLine(i);
            //    if (i == 2)
            //    {
            //        break;
            //    }
            //}

            ////break statement with inner loop
            //Console.WriteLine("Break within inner loop");
            //for (int i = 1; i < 3; i++)
            //{
            //    for(int j = 1; j < 3; j++)
            //    {
            //        Console.WriteLine(i+" "+j);
            //        if (i == 2 && j==2)
            //        {
            //            break;
            //        }

            //    }
            //}

            ////continue
            //Console.WriteLine("continue");
            //for (int i = 1; i <= 3; i++)
            //{
            //    if (i == 2)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            ////continue statement with inner loop
            //Console.WriteLine("continue within inner loop");
            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j < 3; j++)
            //    {
            //        if (i == 2 && j == 2)
            //        {
            //            continue;
            //        }
            //        Console.WriteLine(i + " " + j);

            //    }


            //Exercise1();



            //verbatim literal
            Console.Write("Verbatim literal: ");
            string name = @"Hello \ World";
            Console.WriteLine($"{name}");

            //reference types - nullable
            string str = null;
            //Console.WriteLine(str);

            //value types - not nullable
            //int n = null   //gives Cannot convert null to 'int' because it is a non - nullable value type   

            //to make value types nullable, insert ? as suffix to datatype
            //int? n = null;

            //int availableNum = n ?? 0;          //null coalescing operator

            //ArrayMethod();

            //commanLine Arguements
            Console.WriteLine("Arguements length: " + args.Length);
            Console.WriteLine("Supplied arguments are: ");
            foreach (Object obj in args)
            {
                Console.WriteLine(obj);
            }
            {
                
            }

        }
    }
}
