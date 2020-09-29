using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recrusive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv et tal eller bogstaver");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial of " + number + " is " + factorial(number));
            Console.ReadLine();

        }


        static int factorial(int n)
        {
            if (n == 0)
                return 1;


            return n * factorial(n - 1);
        }
    }

}

