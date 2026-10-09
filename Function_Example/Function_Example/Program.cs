using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Example
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            //calculator.Addition(5, 10, '+');
            //calculator.GenricCaculator(5, 10, '-');
            //calculator.Addition(5, 10, '*');
            //calculator.Addition(5, 10,
            


            // No Return Type No Parameter
            calculator.Display();


            // Without Return with Parameter
            calculator.DisplayName("Tushar");


            // With Return Without Parametr Type
            string name = calculator.GetName();
            Console.WriteLine("Name : " + name);


            //With Return Type With parameter
            string name1 = calculator.DisplayName2("tushar");
            Console.WriteLine("name : " + name);


            Console.ReadLine();

        }
    }
}
