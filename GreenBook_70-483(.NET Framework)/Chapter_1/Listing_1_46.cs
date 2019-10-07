using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GreenBook_70_483_.NET_Framework.Chapter_1
{
    // Added the Thread.Sleep for better visual of locking
    class Listing_1_46
    {
        static object lock1 = new object();
        static object lock2 = new object();
        public static void Method1()
        {
            lock (lock1)
            {
                Console.WriteLine("Method 1 got lock 1");
                Console.WriteLine("Method 1 waiting for lock 2");

                Thread.Sleep(2000);

                lock (lock2)
                {
                    Console.WriteLine("Method 1 got lock 2");

                    Thread.Sleep(2000);
                }
                Console.WriteLine("Method 1 released lock 2");
            }
            Console.WriteLine("Method 1 released lock 1");
        }
        public static void Method2()
        {
            lock (lock2)
            {
                Console.WriteLine("Method 2 got lock 2");
                Console.WriteLine("Method 2 waiting for lock 1");

                Thread.Sleep(2000);
                lock (lock1)
                {
                    Console.WriteLine("Method 2 got lock 1");

                    Thread.Sleep(2000);
                }
                Console.WriteLine("Method 2 released lock 1");
            }
            Console.WriteLine("Method 2 released lock 2");
        }
        public static void Start()
        {
            Method1();
            Method2();
            Console.WriteLine("Methods complete. Press any key to exit.");
            Console.ReadKey(); }
    }
}
