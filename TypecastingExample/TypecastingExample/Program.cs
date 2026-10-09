using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypecastingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Explicit typecasting from double to int


            //double price = 9.78;
            //int value = Convert.ToInt16(price); 
            //Console.WriteLine(value);

            //string number = "T";
            //int amount = int.Parse(number);
            //Console.WriteLine(amount);

            int money = 230000;
            string updatedMoney = Convert.ToString(money);
            Console.Write("Updated money"+updatedMoney);
            


            //Implicit typecasting from int to double

            //int a = 10;
            //long b = a;
            //Console.WriteLine(b);

           


        }
    }
}
