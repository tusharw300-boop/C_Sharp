using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter Your Age : ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //if (age >= 18)
            //{
            //    Console.WriteLine("You are eligible for voting");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible for voting");
            //}
            //Console.ReadLine();

            Console.WriteLine("Enter Your Marks : ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if(marks>100 || marks<0)
            {
                Console.WriteLine("Enter Valid Marks");
            }
            else if(marks<=100 && marks>90)
            {
                Console.WriteLine("You passed with A+ grade!!!");
            }
            else if(marks<=90 && marks>=71)
            {
                Console.WriteLine("You passed with A grade!!!");
            }
            else if (marks <= 70 && marks >= 35)
            {
                Console.WriteLine("You are passed!!!");
            }
            else
            {
                Console.WriteLine("You failed!!!!");
            }



        }
    }
}
