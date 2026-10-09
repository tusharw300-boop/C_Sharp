using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int value = Convert.ToInt32(Console.ReadLine());

            for(int number = 0; number <= value; number++)
            {
                if(number >= 6)
                {
                    break; 
                }
               Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
