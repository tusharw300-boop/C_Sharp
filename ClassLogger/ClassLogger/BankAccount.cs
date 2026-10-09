using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLogger
{
    public static class BankAccount
    {
      public static void Deposit(decimal amount)
        {
            Logger.information($"Depositing {amount} to the bank account.");
            
        }
        public static void Withdraw(decimal amount)
        {
            Logger.information($"Withdrawing {amount} from the bank account.");
        }
    }
}
