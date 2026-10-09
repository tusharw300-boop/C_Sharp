using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();

            Console.Write("Enter A Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = factorial.FactorialOfNumber(number);

            Console.WriteLine("Factorial is : " + result);
        }
    }
}
