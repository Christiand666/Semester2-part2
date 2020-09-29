using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recrusion
{
    class Program
    {
        static long[] numbers;
        static void Main(string[] args)
        {
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());

            numbers = new long[n + 2];
            numbers[1] = 1;
            numbers[2] = 1;

            long result = fib(n);
            Console.WriteLine("fib({0}) ={1}", n, result);

        }


        static long fib(int n)
        {
            if (0 == numbers[n])
            {
                numbers[n] = fib(n - 1) + fib(n - 2);
            }
            return numbers[n];
        }
    }
}
