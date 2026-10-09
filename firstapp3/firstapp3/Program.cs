using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Numbar to check even or odd");
            int number = Convert.ToInt16(Console.ReadLine());
            if(number % 2 == 0)
            {
                Console.WriteLine("Even number:"+number);

            }
            else
            {
                Console.WriteLine("it is odd number:");
                
            }
        }
    }
}
