using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternQuestion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A Number : ");
            int value = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= value; i++)
            {
                // Spaces
                for (int j = 1; j <= value - i; j++)
                {
                    Console.Write("  ");
                }

                // Increasing numbers
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k + " ");
                }

                // Decreasing numbers
                for (int l = i - 1; l >= 1; l--)
                {
                    Console.Write(l + " ");
                }

                Console.WriteLine();

            }
        }
    }
}
