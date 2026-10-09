using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckBudget
{
    public class ExpenseManager
    {
        private List<Traveler> travelers;

        public ExpenseManager(List<Traveler> travelers)
        {
            this.travelers = travelers;
        }

        public decimal CalculateTotalExpense()
        {
            decimal totalExpense = 0;

            foreach (Traveler traveler in travelers)
            {
                totalExpense += traveler.AmountPaid;
            }

            return totalExpense;
        }

        public decimal CalculatePerPersonExpense()
        {
            decimal totalExpense = CalculateTotalExpense();

            return totalExpense / travelers.Count;
        }

        public void DisplayExpenseSummary()
        {
            decimal totalExpense = CalculateTotalExpense();
            decimal perPersonExpense = CalculatePerPersonExpense();

            Console.WriteLine("\n========== EXPENSE SUMMARY ==========");

            Console.WriteLine($"Total Expense      : ₹{totalExpense:F2}");
            Console.WriteLine($"Number of Persons  : {travelers.Count}");
            Console.WriteLine($"Per Person Expense : ₹{perPersonExpense:F2}");

            Console.WriteLine("\n---------- Person Details ----------");

            foreach (Traveler traveler in travelers)
            {
                decimal balance = traveler.AmountPaid - perPersonExpense;

                if (balance > 0)
                {
                    Console.WriteLine(
                        $"{traveler.Name} paid ₹{traveler.AmountPaid:F2} and should receive ₹{balance:F2}");
                }
                else if (balance < 0)
                {
                    Console.WriteLine(
                        $"{traveler.Name} paid ₹{traveler.AmountPaid:F2} and should pay ₹{Math.Abs(balance):F2}");
                }
                else
                {
                    Console.WriteLine(
                        $"{traveler.Name} is settled.");
                }
            }
        }

        public void CalculateSettlement()
        {
            decimal perPersonExpense = CalculatePerPersonExpense();

            // Create copies of balances
            List<TravelerBalance> balances = new List<TravelerBalance>();

            foreach (Traveler traveler in travelers)
            {
                decimal balance = traveler.AmountPaid - perPersonExpense;

                balances.Add(
                    new TravelerBalance
                    {
                        Name = traveler.Name,
                        Balance = balance
                    });
            }

            Console.WriteLine("\n========== FINAL SETTLEMENT ==========");

            int payerIndex = 0;
            int receiverIndex = 0;

            while (payerIndex < balances.Count &&
                   receiverIndex < balances.Count)
            {
                // Find a person who needs to pay
                while (payerIndex < balances.Count &&
                       balances[payerIndex].Balance >= 0)
                {
                    payerIndex++;
                }

                // Find a person who should receive
                while (receiverIndex < balances.Count &&
                       balances[receiverIndex].Balance <= 0)
                {
                    receiverIndex++;
                }

                if (payerIndex >= balances.Count ||
                    receiverIndex >= balances.Count)
                {
                    break;
                }

                decimal amountToPay = Math.Abs(
                    balances[payerIndex].Balance);

                decimal amountToReceive =
                    balances[receiverIndex].Balance;

                decimal settlementAmount =
                    Math.Min(amountToPay, amountToReceive);

                Console.WriteLine(
                    $"{balances[payerIndex].Name} will give " +
                    $"{balances[receiverIndex].Name}: ₹{settlementAmount:F2}");

                balances[payerIndex].Balance += settlementAmount;
                balances[receiverIndex].Balance -= settlementAmount;
            }
        }

        private class TravelerBalance
        {
            public string Name { get; set; }
            public decimal Balance { get; set; }
        }
    }
}