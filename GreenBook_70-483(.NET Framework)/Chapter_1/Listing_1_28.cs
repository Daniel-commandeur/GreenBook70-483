using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GreenBook_70_483_.NET_Framework.Chapter_1
{
    class Listing_1_28
    {
        static void DoWork(object state)
        {
            Console.WriteLine("Doing work: {0}", state);
            Thread.Sleep(500);
            Console.WriteLine("Work finished: {0}", state);
        }
        public static void Start()
        {
            for (int i = 0; i < 50; i++)
            {
                int stateNumber = i;
                ThreadPool.QueueUserWorkItem(state => DoWork(stateNumber));
            }

            Console.ReadKey();
        }
    }
}
