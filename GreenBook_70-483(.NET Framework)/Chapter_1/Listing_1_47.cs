using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook_70_483_.NET_Framework.Chapter_1
{
    class Listing_1_47
    {
        public static void Start()
        {
            Task t1 = Task.Run(() => Listing_1_46.Method1());
            Task t2 = Task.Run(() => Listing_1_46.Method2());
            Console.WriteLine("waiting for Task 2");
            t2.Wait();
            Console.WriteLine("Tasks complete. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
