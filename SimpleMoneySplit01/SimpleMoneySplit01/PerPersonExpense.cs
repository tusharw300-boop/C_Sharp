using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMoneySplit01
{
    public class PerPersonExpense
    {
        decimal perPersonExpense, tusharExpense, nishantExpense, ajayExpense;
        decimal tusharProfitAmount, tusharLossAmount;
        decimal nishantProfitAmount, nishantLossAmount;
        decimal ajayProfitAmount, ajayLossAmount;
        int tusharFlag = 0;
        int nishantFlag = 0;
        int ajayFlag = 0;

        public void setExpenseData(decimal tusharExpenseData, decimal nishantExpenseData, decimal ajayExpenseData)
        {
            tusharExpense = tusharExpenseData;
            nishantExpense = nishantExpenseData;
            ajayExpense = ajayExpenseData;
        }
        public void CalculatePerPersonExpense()
        {
            perPersonExpense = (tusharExpense + nishantExpense + ajayExpense) / 3;
            Console.WriteLine($"Per person expense: {perPersonExpense}");

        }
        public void CalculateTusharExpense()
        {
            if (tusharExpense > perPersonExpense)
            {
                tusharProfitAmount = tusharExpense - perPersonExpense;
                Console.WriteLine($"Tushar will get Rs: {tusharProfitAmount}");
                tusharFlag = 1; 
            }
            else if (tusharExpense < perPersonExpense)
            {
                tusharLossAmount = perPersonExpense - tusharExpense;
                Console.WriteLine($"Tushar will give Rs: {tusharLossAmount}");
                tusharFlag = 1;
            }
        }
        public void CalculateNishantExpense()
        {
            if (nishantExpense > perPersonExpense)
            {
                nishantProfitAmount = nishantExpense - perPersonExpense;
                Console.WriteLine($"Nishant will get Rs: {nishantProfitAmount}");
                nishantFlag = 1;
            }
            else if (nishantExpense < perPersonExpense)
            {
                nishantLossAmount = perPersonExpense - nishantExpense;
                Console.WriteLine($"Nishant will give Rs: {nishantLossAmount}");
                nishantFlag = 1;
            }
        }
        public void CalculateAjayExpense()
        {
            if (ajayExpense > perPersonExpense)
            {
                ajayProfitAmount = ajayExpense - perPersonExpense;
                Console.WriteLine($"Ajay will get Rs: {ajayProfitAmount}");
                ajayFlag = 1;
            }
            else if (ajayExpense < perPersonExpense)
            {
                ajayLossAmount = perPersonExpense - ajayExpense;
                Console.WriteLine($"Ajay will give Rs: {ajayLossAmount}");
                ajayFlag = 1;
            }
        }
        public void CalculateFinalSettlementOfTushar()
        {
            if (ajayFlag == 1)
            {
                decimal finalTusharProfit = tusharProfitAmount;
                Console.WriteLine($"Ajay will give Tushar: {finalTusharProfit}");

            }
            else if (nishantFlag == 1)
            {
                decimal finalTusharProfit = tusharProfitAmount;
                Console.WriteLine($"Nishant will give Tushar: {finalTusharProfit}");
            }
        }
        public void CalculateFinalSettlementOfNishant()
        {
            if (ajayFlag == 1)
            {
                decimal finalNishantProfit = nishantProfitAmount;
                Console.WriteLine($"Ajay will give Nishant: {finalNishantProfit}");

            }
            else if (tusharFlag == 1)
            {
                decimal finalNishantProfit = nishantProfitAmount;
                Console.WriteLine($"Tushar will give Nishant: {finalNishantProfit}");
            }
        }
        public void CalculateFinalSettlementOfAjay()
        {
            if (nishantFlag == 1)
            {
                decimal finalAjayProfit = ajayProfitAmount;
                Console.WriteLine($"Nishant will give Ajay: {finalAjayProfit}");

            }
            else if (tusharFlag == 1)
            {
                decimal finalAjayProfit = ajayProfitAmount;
                Console.WriteLine($"Tushar will give Ajay: {finalAjayProfit}");
            }
        }

    }
}