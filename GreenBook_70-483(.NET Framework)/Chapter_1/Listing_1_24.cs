using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GreenBook_70_483_.NET_Framework.Chapter_1
{
    class Listing_1_24
    {
        static bool tickRunning;  // flag variable
        public static void Start()
        {
            tickRunning = true;
            Thread tickThread = new Thread(() =>
            {
                while (tickRunning)
                {
                    Console.WriteLine("Tick");
                    Thread.Sleep(1000);
                }
            });

            tickThread.Start();
            Console.WriteLine("Press a key to stop the clock");
            Console.ReadKey();
            tickRunning = false;
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
