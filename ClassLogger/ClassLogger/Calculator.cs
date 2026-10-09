using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLogger
{
    public static class Calculator
    {
        public static int Add(int a, int b)
        {
            Logger.information($"Adding Two Numbers {a} and {b}");
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            Logger.information($"Subtracting Two Numbers {b} from {a}");
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            Logger.information($"Multiplying Two Numbers {a} and {b}");
            return a * b;
        }
        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                Logger.error("Division by zero is not allowed.");
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            Logger.information($"Dividing Two Numbers {a} by {b}");
            return (double)a / b;
        }
    }
}
