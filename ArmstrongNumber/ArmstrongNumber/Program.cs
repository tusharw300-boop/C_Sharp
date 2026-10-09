using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0,temp = 0, remainder, originalNumber = 0,count = 0;

            Console.Write("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            originalNumber = number;
            temp = number;

            if(number < 0)
            {
                Console.WriteLine("Please enter a positive number.");
                return;
            }
            if (temp == 0)
            {
                count = 1;
            }

            else
            {
                while (temp > 0)
                {
                    temp /= 10;
                    count++;
                }
            }

            while (number > 0)
            {
                remainder = number % 10;
                sum += (int)Math.Pow(remainder, count);
                number /= 10;
            }
            
            if (sum == originalNumber)
            {
                Console.Write("{0} is an Armstrong number.", originalNumber);
            }
            else
            {
                Console.Write("{0} is not an Armstrong number.", originalNumber);
            }
            Console.ReadLine();
        }
    }
}
