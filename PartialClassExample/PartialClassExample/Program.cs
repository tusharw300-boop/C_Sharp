using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();



            Console.WriteLine(" ");
            Console.WriteLine("Employee Details:");
            Console.WriteLine(" ");

            employee.DisplayEmployeeDetails("Darshan", 12345, 50000);


            Console.WriteLine(" ");
            Console.WriteLine("Employee Bonus Details:");
            Console.WriteLine(" ");

            employee.CalculeteBonusAndDisplay(50000);
            decimal bonus = employee.CalculateBonus(50000);


            Console.WriteLine($"Employee CalculateBonusDetails: {bonus}");


            Console.WriteLine(" ");
            Console.WriteLine("Employee DepartmentDetails:");
            Console.WriteLine(" ");

            employee.DiplayEmployeeDepartment("IT");

            Console.ReadLine();


        }
    }
}
