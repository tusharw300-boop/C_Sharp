using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum sum = new Sum();

            Console.Write("Enter A Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = sum.Addition(number);

            Console.WriteLine("Addition is : " + result);
        }
    }
}
