using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAlculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char y;
            Console.WriteLine("enter first number");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter second number");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Which operation do you want to perform");
            Console.WriteLine(" + " + " * " + " - " + " / ");
            y = Convert.ToChar(Console.ReadLine());
            switch (y)
            {
                case '+': Console.WriteLine($"The sum of {a} and {b} is {a + b}"); break;
                case '*': Console.WriteLine($"The multiplication of {a} and {b} is {a * b}"); break;
                case '-': Console.WriteLine($"The substraction of {a} and {b} is {a - b}"); break;
                case '/': Console.WriteLine($"The sum of {a} and {b} is {a / b}"); break;

                default: Console.WriteLine("Invalid number");break;
            }
        }
    }
}
