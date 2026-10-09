using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBudget
{
    public class Traveler
    {

        public string Name { get; set; }
        public decimal AmountPaid { get; set; }

        public Traveler(string name, decimal amountPaid)
        {
            Name = name;
            AmountPaid = amountPaid;
        }





    }
}

