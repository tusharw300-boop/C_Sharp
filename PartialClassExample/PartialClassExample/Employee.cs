using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample
{
    public partial class Employee
    {
        public void DisplayEmployeeDetails(string name, int id, decimal salary)
        {
            Console.WriteLine($"Employee Name: {name}");
            Console.WriteLine($"Employee ID: {id}");
            Console.WriteLine($"Employee salary: {salary}");
        }
    }
}
