using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook_70_483_.NET_Framework.Chapter_1
{
    class Listing_1_39
    {
        public static void Start()
        {
            ConcurrentBag<string> bag = new ConcurrentBag<string>();
            bag.Add("Rob");
            bag.Add("Miles");
            bag.Add("Hull");
            string str;

            if (bag.TryPeek(out str))
                if (str != "Hull")
                    Console.WriteLine("Peek: {0}", str);

            if (bag.TryTake(out str))
                if (str != "Hull")
                    Console.WriteLine("Take: {0}", str);

            Console.ReadKey();
        }
    }
}
