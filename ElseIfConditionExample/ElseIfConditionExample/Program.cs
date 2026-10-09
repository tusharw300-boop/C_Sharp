using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElseIfConditionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Marks : ");
            double marks = Convert.ToDouble(Console.ReadLine());

            if(marks <= 30)
            {
                Console.WriteLine("You are Failed ");
            }
            else if(marks > 31 && marks <= 50)
            {
                Console.WriteLine("You are pass");
            }
            else if(marks > 51 && marks <= 70)
            {
                Console.WriteLine("You are good in study");
            }
            else if(marks >= 71 && marks <= 90)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
