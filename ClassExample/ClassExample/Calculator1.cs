using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    internal class Calculator1
    {
        public void Addition(decimal firstNumber, decimal secondNumber)
        {
            decimal result = firstNumber + secondNumber;
            Console.WriteLine("The result of addition is : " + result);
        }
        public void Substractoin(decimal firstNumber, decimal secondNumber)
        {
            decimal result = firstNumber - secondNumber;
            Console.WriteLine("The result of Substraction is : " + result);
        }
        public void Multiplication(decimal firstNumber, decimal secondNumber)
        {
            decimal result = firstNumber * secondNumber;
            Console.WriteLine("The result of Multiplication is : " + result);
        }
        public void Division(decimal firstNumber, decimal secondNumber)
        {

            decimal result = firstNumber / secondNumber;
            Console.WriteLine("The result of division  is : " + result);
        }
    }
}
