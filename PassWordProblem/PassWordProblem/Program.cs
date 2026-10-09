using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassWordProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter password:");
           int password = Convert.ToInt32(Console.ReadLine());

            while (password != 1234)
            {
                Console.WriteLine("Password is incorrect please enter correct pass");
                password = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("password is correct");
            




        }
    }
}
