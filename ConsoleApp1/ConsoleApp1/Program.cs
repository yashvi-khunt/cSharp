using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
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
            //}

            
            for(int i = 1; i <= 5; i++) 
            {
                int temp = 65;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(Convert.ToChar(temp));
                    temp++;
                }
                temp -= 2;
                //temp = 63;
                for (int j = 1; j < i; j++)
                {
                    
                    Console.Write(Convert.ToChar(temp));
                    temp--;
                }
                Console.WriteLine();
            }

            Console.WriteLine("Enter a number for loop: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int temp = 65;
                for (int j = 1; j <=2*i-1; j++)
                {
                    Console.Write(Convert.ToChar(temp));
                    if(j<i)
                    {
                        temp++;
                        if(temp > 90)
                        {
                            temp = 65;
                        }
                    }
                    else
                    {
                        temp--;
                        if(temp < 65)
                        {
                            temp = 90;
                        }
                    }

                    
                }
                Console.WriteLine();
            }

        }
    }
}
