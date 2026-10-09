using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    internal class Sum
    {
        public int Addition(int number)
        {
            int sum = 0;
            int digit = 0;

            while (number > 0)
            {
                digit = number % 10;
                sum = sum + digit;
                number = number / 10;

            }
            return sum;
        }
    }
}
