using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Calculator calculator = new Calculator();

            Console.Write("Enter the First Number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second Number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            calculator.Addition(firstNumber, secondNumber);

            calculator.Substractoin(firstNumber, secondNumber);

            calculator.Multiplication(firstNumber, secondNumber);

            calculator.Division(firstNumber, secondNumber);

            Console.ReadLine();

        }
    }
}
