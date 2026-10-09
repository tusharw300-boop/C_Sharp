using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;
            string name;
            char grade = '6';
            Console.WriteLine(grade);

            // Boolian data type 

            bool status;
            status = true;
            Console.WriteLine(status);

            // DateTime data type

            DateTime date;
            date = DateTime.Now;
            Console.WriteLine(date);

            // Float data type

            float price;
            price = 10.05f;
            Console.WriteLine(price);

            // Decimal data type

            decimal amount;
            amount = 100.05m;
            Console.WriteLine(amount);

            // double data type

            double distance;
            distance = 100.05;
            Console.WriteLine(distance);

        }
    }
}
