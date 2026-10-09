using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExampleBankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            BankAccount bankaccount = new BankAccount();
            bankaccount.set_data("Tushar", 1000, 500);
            //bankaccount.credit(1000);
            //bankaccount.debit(500);

            bankaccount.display1();
            bankaccount.display2();
        }
    }
}
