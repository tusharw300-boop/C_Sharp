using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int reversedNumber = 0, remainder, originalNumber;
            Console.Write("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            originalNumber = number;

            if(number < 0)
            {
                Console.WriteLine("Negative numbers cannot be palindromes.");
                return;
            }

            while (number > 0)
            {
                remainder = number % 10;
                reversedNumber = (reversedNumber * 10) + remainder;
                number = number / 10;
            }

            if (originalNumber == reversedNumber)
            {
                Console.WriteLine("The number is a palindrome.");
            }
            else
            {
                Console.WriteLine("The number is not a palindrome.");
            }
            Console.ReadLine();
        }
    }
}
