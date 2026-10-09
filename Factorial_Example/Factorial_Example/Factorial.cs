using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Example
{
    internal class Factorial
    {
        public int FactorialOfNumber(int number)
        {
            int factorial = 1;
            for(int i=1;i<=number;i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
