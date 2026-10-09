using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample
{
    public partial class Employee
    {
        public void DiplayEmployeeDepartment(string department)
        {
            Console.WriteLine($"Employee Department: {department}");
        }
    }
}
