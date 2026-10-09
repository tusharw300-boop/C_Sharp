using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number");
            int number = Convert.ToInt32(Console.ReadLine());


            string result = (number % 2 == 0) ? "Even" : "odd";

            Console.WriteLine("Result : " + result);
        }
    }
}
