using System;
using System.Collections.Generic;

namespace CheckBudget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("       CHECK BUDGET");
            Console.WriteLine("=================================");

            Console.Write("\nEnter number of persons: ");
            int numberOfPersons = Convert.ToInt32(Console.ReadLine());

            List<Traveler> travelers = new List<Traveler>();

            for (int i = 0; i < numberOfPersons; i++)
            {
                Console.WriteLine($"\n--- Person {i + 1} ---");

                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter amount paid: ₹");
                decimal amountPaid = Convert.ToDecimal(
                    Console.ReadLine());

                Traveler traveler = new Traveler(name,amountPaid);

                 travelers.Add(traveler);
            }

            ExpenseManager expenseManager = new ExpenseManager(travelers);

            expenseManager.DisplayExpenseSummary();

            expenseManager.CalculateSettlement();

            Console.WriteLine("\n=================================");
            Console.WriteLine("       Calculation Completed");
            Console.WriteLine("=================================");

            Console.ReadLine();
        }
    }
}