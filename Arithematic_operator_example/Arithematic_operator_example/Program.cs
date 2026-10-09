using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithematic_operator_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Any Value : ");
            int principleValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Interest Rate : ");
            double interestRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Time Period in Year: ");
            int timePeriod = Convert.ToInt32(Console.ReadLine());

            double simpleInterest = (principleValue * interestRate * timePeriod) / 100;
            Console.Write("Simple Interest : Rs." + simpleInterest);

            string firstName = "Devang ";
            string lastName = "Pandare";

            Console.WriteLine(firstName + lastName);
        }
    }
}
