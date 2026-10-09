using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LargestNumber largestNumber = new LargestNumber();

            Console.Write("Enter the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number:");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            int Largest = largestNumber.FindLargestNumber(firstNumber, secondNumber, thirdNumber);

            Console.WriteLine("The largest number is: " + Largest);
        }
    }
}
