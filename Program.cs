using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                double result;
                Console.Write("Enter first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a symbol:");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("Addition:" + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("Subtraction:" + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("Multiplication:" + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("Division:" + result);
                        break;
                }
                Console.ReadLine();
                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();
            }
            while (value == "y");
        }
    }

}
