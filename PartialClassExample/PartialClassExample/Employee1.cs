using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample
{
    public partial class Employee
    {
        public void CalculeteBonusAndDisplay(decimal salary)
        {
            decimal bonus = (salary * 10) / 100;
            Console.WriteLine($"Employee Bonus: {bonus}");
        }
        public decimal CalculateBonus(decimal salary)
        {
            return salary + ((salary * 10) / 100);
        }
   
    }
}
