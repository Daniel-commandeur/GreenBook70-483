using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GreenBook_70_438.Chapter1
{
    class Listing_1_18
    {
        public static void ThreadHello()
        {
            Console.WriteLine("Hello from the thread");
            Thread.Sleep(2000);
        }
        public static void Start()
        {
            Thread thread = new Thread(ThreadHello);
            thread.Start();
        }
    }
}
