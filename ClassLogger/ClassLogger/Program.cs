using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Logger.information("Start Main method");

            int Result = 5 + 10;

            Logger.information($"Result: {Result}");

            Console.WriteLine(" ");
            Console.WriteLine("Employee Details:");
            Console.WriteLine(" ");

            Employee.Name("Tushar");

            Employee.Id(123);

            Employee.Salary(50000m);

            Employee.Work();


            Console.WriteLine(" ");
            Console.WriteLine("Bank Account Details:");
            Console.WriteLine(" ");


            BankAccount.Deposit(1000);

            BankAccount.Withdraw(500);


            Console.WriteLine(" ");
            Console.WriteLine("Calculator Details:");
            Console.WriteLine(" ");


            int addResult = Calculator.Add(5, 10);
            Console.WriteLine($"Add Result : {addResult}");

            int subtractResult = Calculator.Subtract(10, 5);
            Console.WriteLine($"Subtract Result : {subtractResult}");

            int multiplyResult = Calculator.Multiply(5, 10);
            Console.WriteLine($"Multiply Result : {multiplyResult}");

            double divideResult = Calculator.Divide(10, 5);
            Console.WriteLine($"Divide Result : {divideResult}");

            Logger.information("End Main method");

            Console.ReadLine();

        }
    }
}
