using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedIfElseExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10th marks: ");
            double marks10th = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter 12th marks: ");
            double marks12th = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter degree marks: ");
            double marksDegree = Convert.ToDouble(Console.ReadLine());

            if (marks10th >= 60)
            {
                if(marks12th >= 60)
                {
                    if(marksDegree >=  60)
                    {
                        Console.WriteLine("you are eligible");
                    }
                }    
            }
            else
            {
                Console.WriteLine("you are not eligible");
            }
        }
    }
}
