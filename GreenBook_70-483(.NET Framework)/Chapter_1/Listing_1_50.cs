using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GreenBook_70_483_.NET_Framework.Chapter_1
{
    class Listing_1_50
    {
        public static void Start()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            Task clock = Task.Run(() => Listing_1_49.Clock(cancellationTokenSource.Token));
            Console.WriteLine("Press any key to stop the clock");
            Console.ReadKey();
            if (clock.IsCompleted)
            {
                Console.WriteLine("Clock task completed");
            }
            else
            {
                try
                {
                    cancellationTokenSource.Cancel();
                    clock.Wait();
                }
                catch (AggregateException ex)
                {
                    Console.WriteLine("Clock stopped: {0}", ex.InnerExceptions[0].ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
