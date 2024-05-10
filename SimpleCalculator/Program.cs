using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Simple Calculator App!");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Enter the first number: ");
            var firstNumber = Console.ReadLine();
            Console.WriteLine("Enter the second number: ");
            var secondNumber = Console.ReadLine();
            Console.WriteLine("What is the operation you want to perform? (+, -, /, *) only");
            var inputOperator = Console.ReadLine();

            string assignedOperator = null;
            double givenTotal = 0;

            switch (inputOperator)
            {
                case "+":
                    assignedOperator = "add";
                    givenTotal = double.Parse(firstNumber) + double.Parse(secondNumber);
                    break;
                case "-":
                    assignedOperator = "minus";
                    givenTotal = double.Parse(firstNumber) - double.Parse(secondNumber);
                    break;
                case "/":
                    assignedOperator = "divide";
                    givenTotal = double.Parse(firstNumber) / double.Parse(secondNumber);
                    break;
                case "*":
                    assignedOperator = "multiply";
                    givenTotal = double.Parse(firstNumber) * double.Parse(secondNumber);
                    break;
                default:
                    Console.WriteLine("Invalid operator assigned");
                    break;
            }
            Console.WriteLine("You want to {0} {1} and {2}.", assignedOperator, firstNumber, secondNumber);
            Console.WriteLine($"Your total is {givenTotal}.");


        }


    }
}
