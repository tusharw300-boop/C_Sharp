using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExample
{
    internal class LargestNumber
    {
        public int FindLargestNumber(int a,int b, int c)
        {
            int largest = a;
            if (b > largest)
            {
                largest = b;
            }
            if (c > largest)
            {
                largest = c;
            }
            return largest;
        }
    }
}
