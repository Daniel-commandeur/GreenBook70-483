using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GreenBook_70_483_.NET_Framework.Chapter_1
{
    class Listing_1_25
    {
        public static void Start()
        {
            Thread threadToWaitFor = new Thread(() =>
            {
                Console.WriteLine("Thread starting");
                Thread.Sleep(2000);
                Console.WriteLine("Thread done");
            });

            threadToWaitFor.Start();
            Console.WriteLine("Joining thread");
            threadToWaitFor.Join();
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
