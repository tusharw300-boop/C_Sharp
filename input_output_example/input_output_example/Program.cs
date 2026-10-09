using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_output_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            int firstNumber = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Second Number : ");
            int secondNumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Addition of two numbers is : " + (firstNumber + secondNumber) );

            Console.WriteLine("Subtraction of two numbers is : " + (firstNumber - secondNumber) );

            Console.WriteLine("Multiplication of two numbers is : " + (firstNumber * secondNumber) );
            
            Console.WriteLine("Division of two numbers is : " + (firstNumber / secondNumber) );

            Console.ReadLine();

        }
    }
}
