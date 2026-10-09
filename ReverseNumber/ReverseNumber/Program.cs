using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to reverse: ");
            long number = Convert.ToInt64(Console.ReadLine());

            long reverse = 0;
            long digit;
            long sign = 1;

            if (number < 0)
            {
                sign = -1;
                number = -number;
            }

            while (number > 0)
            {
                digit = number % 10;
                reverse = (reverse * 10) + digit;
                number = number / 10;
            }

            reverse = reverse * sign;

            Console.WriteLine("Reversed Number: " + reverse);
            Console.ReadLine();
        }
    }
}
