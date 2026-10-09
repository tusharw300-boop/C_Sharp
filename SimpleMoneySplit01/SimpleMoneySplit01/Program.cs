using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMoneySplit01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string personName;

            //Console.WriteLine("Enter Total Number of People:");
            //int totalPeople = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= totalPeople; i++)
            //{
            //    Console.WriteLine($"Enter Person {i} name: ");
            //    personName = Console.ReadLine();

            //    for (int j = 1; i <= totalPeople; j++)
            //    {
            //        Console.WriteLine($"Enter Expense of {personName}:");
            //        decimal expense = Convert.ToDecimal(Console.ReadLine());
            //        break;
            //    }
            //}


            PerPersonExpense perPersonExpense = new PerPersonExpense();
            perPersonExpense.setExpenseData(1000m, 500m, 100m);
            perPersonExpense.CalculatePerPersonExpense();
            perPersonExpense.CalculateTusharExpense();
            perPersonExpense.CalculateNishantExpense();
            perPersonExpense.CalculateAjayExpense();

            perPersonExpense.CalculateFinalSettlementOfTushar();
            perPersonExpense.CalculateFinalSettlementOfNishant();
            perPersonExpense.CalculateFinalSettlementOfAjay();
        }
    }
}
