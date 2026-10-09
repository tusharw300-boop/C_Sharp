using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

           

            Console.WriteLine("Enter Opertor");
            char operatorSymbol = Convert.ToChar(Console.ReadLine());

            double result = 0;


            switch (operatorSymbol)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    Console.WriteLine("Addition of two numbers");
                    break;

                case '-':
                    result = firstNumber - secondNumber;
                    Console.WriteLine("Substraction of two numbers");
                    break;

                case '*':
                    result = firstNumber * secondNumber;
                    Console.WriteLine("Multiplication of two numbers");
                    break;

                    case '/':
                    result = firstNumber / secondNumber;
                    break;

                default:
                    Console.WriteLine("You Enter invalid");
                    Console.WriteLine("Divide of two numbers");
                    break;
            }
            Console.WriteLine($"Result : {result}");


        }
    }
}
