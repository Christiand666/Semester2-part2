using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletonprojekt1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> etnavn = new List<int> { 1, 2, 3, 4, 5 };

            Singleton første1 = Singleton.GetInstance();
            første1.SetData(etnavn);
            //Singleton første2 = Singleton.GetInstance();
            //Singleton første3 = Singleton.GetInstance();
            //Singleton første4 = Singleton.GetInstance();
            //Singleton første5 = Singleton.GetInstance();
            //Singleton første6 = Singleton.GetInstance();
            //Singleton første7 = Singleton.GetInstance();
            //Singleton første8 = Singleton.GetInstance();
            //Singleton første9 = Singleton.GetInstance();
            //Singleton første10 = Singleton.GetInstance();



            //Console.WriteLine(første1.GetData());
            //Console.WriteLine(første2.GetData());
            //Console.WriteLine(første3.GetData());
            //Console.WriteLine(første4.GetData());
            //Console.WriteLine(første5.GetData());
            //Console.WriteLine(første6.GetData());
            //Console.WriteLine(første7.GetData());
            //Console.WriteLine(første8.GetData());
            //Console.WriteLine(første9.GetData());
            //Console.WriteLine(første10.GetData());
            foreach (var item in første1.GetData())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }


        //private static void scope1()
        //{
        //    Singleton første1 = Singleton.GetInstance();
        //    første1.SetData(10);
        //}

        //private static void scope2()
        //{
        //    Singleton første1 = Singleton.GetInstance();
        //    første1.SetData(30);
        //}
    }

}
