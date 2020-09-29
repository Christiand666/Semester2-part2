using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Multithreading_med_de_forskellige_search
{
    class Program
    {
        private static Stopwatch stopwatch = new Stopwatch();
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            var data = new int[5000];
            for (int i = 0; i < data.Length; i++)
                data[i] =rnd.Next(5000);
            opg2(data);
            opg3(data);
        }


        private static void opg2(int[] arr)
        {
            var data = new int[arr.Length];
            arr.CopyTo(data, 0);
            //1.2

            int qs = new CQuickSort();
            var tråd1 = new Thread(() =>

            {
                stopwatch.Start();
                Array.Sort(data);
                stopwatch.Stop();
                Console.WriteLine("QS tog " + stopwatch.ElapsedMilliseconds + "ms");
                stopwatch.Reset();
            });
            tråd1.Start();
            tråd1.Join();
            var søgeValue = rnd.Next(5000);
            Console.WriteLine("søger efter: " + søgeValue);
            var ls = new InsertionSortClass();
            ls(data, søgeValue);
            }

        private static void opg3(int[] arr)
        {
            var data = new int[arr.Length];
            arr.CopyTo(data, 0);
            var data1 = new int[arr.Length];
            arr.CopyTo(data1, 0);
            var data2 = new int[arr.Length];
            arr.CopyTo(data2, 0);

            var ss = new SelectionSortClass();
            var qs = new CQuickSort();
            var bs = new BubbleSortClass();

            new Thread(() =>
            {
                var sw = new Stopwatch();
                sw.Start();
                qs.sort(data2);
                sw.Stop();
                Console.WriteLine("quicksort tog:  + sw.ElapsedMilliseconds  MS");

            }).Start();




            


        }
    }
}
