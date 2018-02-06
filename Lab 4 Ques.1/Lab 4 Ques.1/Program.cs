//1.	Write a program to explain get set accessor.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_4_Ques._1
{
    class Example
    {
        int _number;
        public int Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example();
            example.Number = 5; // set { }
            Console.WriteLine(example.Number); // get { }
            Console.ReadKey();
        }
    }
}