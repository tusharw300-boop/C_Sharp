using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Choice 1 For stat");

            int value = Convert.ToInt32(Console.ReadLine());

            switch (value)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;


                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursaday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;


                default:
                    Console.WriteLine("You entered Invalid number");
                    break;
            }
        }
    }
}
