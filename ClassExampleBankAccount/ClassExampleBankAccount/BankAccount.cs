using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace ClassExampleBankAccount
{
    public partial class BankAccount 
    {
        string name;
        decimal amount;
        decimal amount1;

        public void set_data(string n, decimal am, decimal am1)
        {
            name = n;
            amount = am;
            amount1 = am1;
        }
        //public void credit(decimal am)
        //{
        //    amount = am;
        //}
        //public void debit(decimal am)
        //{
        //    amount1 = am;
        //}
        //public void display()
        //{
        //    Console.WriteLine("name : " + name);
        //    Console.WriteLine("Credit : " + amount);
        //    Console.WriteLine("Debit : " + amount1);
        //}


    }
    public partial class BankAccount
    {
        public void display2()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("Credit : " + amount);
            Console.WriteLine("Debit : " + amount1);
        }
    }

}
