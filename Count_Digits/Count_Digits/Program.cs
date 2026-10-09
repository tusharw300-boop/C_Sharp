using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountDigits countdigits = new CountDigits();

            Console.Write("Enter A Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = countdigits.Count(number);
            Console.WriteLine("Count is  : " + result);
        }
    }
}
