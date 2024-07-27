// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator program");
            Console.WriteLine("Please enter your first number");
            int a = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Please enter your second number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select the operation d-Division ,a-addition,s-subtraction,m-multiplication");
            string answer = Console.ReadLine();
            switch (answer) {
                case "d":
                    Console.WriteLine(a/b);
                    break;
                case "s":
                    Console.WriteLine(a-b);
                    break;
                case "a":
                    Console.WriteLine(a+b);
                    break;
                case "m":
                    Console.WriteLine(a*b);
                    break;
                default:
                    Console.WriteLine("Incorrect operation");
                    break;
            }


            Console.ReadKey();
        }
    }
}
