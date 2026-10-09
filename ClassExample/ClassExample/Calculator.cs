using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class Calculator
    {
        public void Addition(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            Console.WriteLine("The result of addition is : " + result);
        }
        public void Substractoin(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            Console.WriteLine("The result of Substraction is : " +result);
        }
        public void Multiplication(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            Console.WriteLine("The result of Multiplication is : " + result);
        }
        public void Division(int firstNumber, int secondNumber)
        {

            int result = firstNumber / secondNumber;
            Console.WriteLine("The result of division  is : " + result);
        }


    }
}   
