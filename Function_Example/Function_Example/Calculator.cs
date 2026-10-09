using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Function_Example
{
    internal class Calculator
    {

        public void GenricCaculator(int firstNumber, int secondNumber, char opertor)
        {
            if (opertor == '+')
            {

                Console.WriteLine("Addition of two numbers : " + (firstNumber + secondNumber));
            }
            else if (opertor == '-')
            {
                Console.WriteLine("Subtraction of two numbers : " + (firstNumber - secondNumber));
            }
            else if (opertor == '*')
            {
                Console.WriteLine("Multiplication of two numbers : " + (firstNumber * secondNumber));
            }
            else if (opertor == '/')
            {
                Console.WriteLine("Division of two numbers : " + (firstNumber / secondNumber));
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }

        }

        // No Return Type No Parameter

        public void Display()
        {
            Console.WriteLine("Name : Tushar");
        }

        // Without Return with Parameter

        public void DisplayName(string name)
        {
            Console.WriteLine("name ; " + name);
        }

        // With Return Without Parametr Type

        public string GetName()
        {
            return "Tushar";
        }

        //With Return Type With parameter

        public string DisplayName2(string name)
        {
            return name;
        }

    }
}
