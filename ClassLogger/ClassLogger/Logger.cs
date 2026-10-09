using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLogger
{
    public static class Logger
    {
        public static void information(string message)
        {
            Console.WriteLine($"Information : {message}");
        }
        public static void warning(string message)
        {
            Console.WriteLine($"Warning : {message}");
        }
        public static void error(string message)
        {
            Console.WriteLine($"Error : {message}");
        }
    }
}
