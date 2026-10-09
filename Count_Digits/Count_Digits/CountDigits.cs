using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Digits
{
    internal class CountDigits
    {
        public int Count(int number)
        {
            int count = 0;

            while(number > 0)
            {
                number = number / 10;
                count++;
            }
            return count;
        }
    }
}
