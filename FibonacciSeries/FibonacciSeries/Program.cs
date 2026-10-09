using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter the number of terms for the Fibonacci series:");
                int number = Convert.ToInt32(Console.ReadLine());

                int firstTerm = 0, secondTerm = 1, nextTerm;
                Console.WriteLine("Fibonacci Series:");
                for (int i = 0; i < number; i++)
                {
                    if (i <= 1)
                        nextTerm = i;
                    else
                    {
                        nextTerm = firstTerm + secondTerm;
                        firstTerm = secondTerm;
                        secondTerm = nextTerm;
                    }
                    Console.Write(nextTerm + " ");
                }
                Console.WriteLine("\nDo you want to continue? (y/n)");
            } while (Console.ReadLine().ToLower() == "y");
        }
    }
}
