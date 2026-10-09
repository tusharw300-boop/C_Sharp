using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLogger
{
    public static class Employee
    {
        public static void Name(string name)
        {
            Logger.information($"Employee Name: {name}");
        }
        public static void Id(int id)
        {
            Logger.information($"Employee ID: {id}");
        }
        public static void Salary(decimal salary)
        {
            Logger.information($"Employee Salary: {salary}");
        }
        public static void Work()
        {
            Logger.information("Employee is working.");
        }

    }
}
