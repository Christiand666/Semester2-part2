using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankacct acct = new Bankacct(10);
            Thread[] threads = new Thread[15];

        


            Thread.CurrentThread.Name = "main";

            for (int i = 0; i < 15; i++)
            {
                Thread t = new Thread(new ThreadStart(acct.IssueWitdraw));
                t.Name = i.ToString();
                threads[i] = t;
            }
            
            for (int p = 0; p < 15; p++)
            {
                Thread l = new Thread(new ThreadStart(acct.IssueDeposit));
                l.Name = p.ToString();
                threads[p] = l;
            }

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Thread {0} alive : {1}", threads[i].Name, threads[i].IsAlive);
                threads[i].Start();
                Console.WriteLine("Thread {0} alive : {1}", threads[i].Name, threads[i].IsAlive);
            }

            for (int p = 0; p < 15; p++)
            {
                Console.WriteLine("Thread {0} alive : {1}", threads[p].Name, threads[p].IsAlive);
                threads[p].Start();
                Console.WriteLine("Thread {0} alive : {1}", threads[p].Name, threads[p].IsAlive);
            }



                Console.WriteLine("current priority : {0}", Thread.CurrentThread.Priority);

            Console.WriteLine("Thread {0} Ending", Thread.CurrentThread.Name);

            Console.ReadLine();
        }


    }

    class Bankacct
    {
        private object acctlock = new object();
        double balance { set; get; }

        public Bankacct(double bal)
        {
            balance = bal;
        }
        public double Withdraw(double amt)
        {
            if ((balance - amt) < 0)
            {
                Console.WriteLine($"sorry ${balance} in Acount");
                return balance;
            }
            //alt koden skal akveres før den bliver locked
            lock (acctlock)
            {
                if (balance >= amt)
                {
                    Console.WriteLine("Removed ${0} and ${1} left in acount", amt, (balance - amt));
                    balance -= amt;
                }
                return balance;
            }
        }
        public void IssueWitdraw()
        {
            Withdraw(1);
        }


        public double Deposit(double amt)
        {
            if ((balance + amt) < -1)
            {
                Console.WriteLine($"sorry ${balance} in Acount");
                return balance;
            }
            //alt koden skal akveres før den bliver locked
            lock (acctlock)
            {
                if (balance >= amt)
                {
                    Console.WriteLine("add ${0} and ${1} left in acount", amt, (balance + amt));
                    balance += amt;
                }
                return balance;
            }
        }
        public void IssueDeposit()
        {
            Deposit(1);
        }
    }
   
       
}

    


