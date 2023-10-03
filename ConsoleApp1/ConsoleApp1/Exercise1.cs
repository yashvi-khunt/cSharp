using System;

namespace ConsoleApp1
{
    public class Exercise1
    {
        public void exercise1()
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
    }
}
