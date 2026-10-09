using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void IsPrime(int a)
        {

           if(a <= 1)
            {
                
                return;
            }

            for (int i = 2; i*i <= a; i++)
            {
                if (a % i == 0)
                {
                    return;

                }
            }
           
            
                Console.WriteLine(a);
            
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Number where you check Number is Prime : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i= 1; i <= number; i++)
            {
                IsPrime(i);
            }
        }

        
        
    }
}
