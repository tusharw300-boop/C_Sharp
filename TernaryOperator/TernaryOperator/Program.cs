using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Age : ");
            int age = Convert.ToInt32(Console.ReadLine());


            string output = (age >= 18) ? "You are Eligible to vote " : "You are not eligible to vote";
            {
                 Console.WriteLine(output);
            }
            Console.ReadLine();
        }
    }
}
