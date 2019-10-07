using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GreenBook_70_438.Chapter1
{
    class Listing_1_20
    {
        public static void Start()
        {
            Thread thread = new Thread(() =>
            {
                Console.WriteLine("Hello from the thread");
                Thread.Sleep(1000);
            });
            thread.Start();
            Console.WriteLine("Press a key to end.");
            Console.ReadKey();
        }
    }
}
