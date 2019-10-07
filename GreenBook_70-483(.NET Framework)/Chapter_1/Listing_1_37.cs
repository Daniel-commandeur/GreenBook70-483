using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook_70_483_.NET_Framework.Chapter_1
{
    class Listing_1_37
    {
        public static void Start()
        {
            ConcurrentQueue<string> queue = new ConcurrentQueue<string>();
            queue.Enqueue("Rob");
            queue.Enqueue("Miles");
            string str;

            if (queue.TryPeek(out str))
                Console.WriteLine("Peek: {0}", str);

            if (queue.TryDequeue(out str))
                Console.WriteLine("Dequeue: {0}", str);

            Console.ReadKey();
        }
    }
}
