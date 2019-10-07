using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GreenBook_70_438.Chapter1
{
    class Listing_1_23
    {
        public static void Start()
        {
            Thread tickThread = new Thread(() =>
            {
                while (true)
                {
                    Console.WriteLine("Tick");
                    Thread.Sleep(1000);
                }
            });

            tickThread.Start();
            Console.WriteLine("Press a key to stop the clock");
            Console.ReadKey();
            tickThread.Abort();
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
