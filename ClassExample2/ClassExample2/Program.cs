using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator1 calculator1 = new Calculator1();

            Console.Write("Enter the First Number : ");
            decimal firstNumber = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the Second Number : ");
            decimal secondNumber = Convert.ToDecimal(Console.ReadLine());

            calculator1.Addition(firstNumber, secondNumber);

            calculator1.Substractoin(firstNumber, secondNumber);

            calculator1.Multiplication(firstNumber, secondNumber);

            calculator1.Division(firstNumber, secondNumber);

            Console.ReadLine();


        }
    }
}
