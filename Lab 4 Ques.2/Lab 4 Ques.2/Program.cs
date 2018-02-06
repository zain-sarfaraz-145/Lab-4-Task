//2. Write a program to explain method in C#. Create a static function factorial() that accept a number from user and returns factorial  of the number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_4_Ques._2
{
    class function
    {
        public static void factorial()
        {
            Console.Write("Enter Any Number: ");
            int g = int.Parse(Console.ReadLine());
            int f;
            f = g;
            for (int h = 1; h < g; h++)
            {
                f = f * h;
            }
            Console.Write("Factorial of " + g + " is " + f + "\n\n\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            function.factorial();
            Console.ReadKey();
        }
    }
}
