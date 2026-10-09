using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            int i = 1;

            if (number < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
            else
            {
                while (i <= number)
                {
                    factorial *= i;
                    i++;
                }
            }
            Console.WriteLine("The factorial is: " +factorial);
        }
    }
}
