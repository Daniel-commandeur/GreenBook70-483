using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook_70_483_.NET_Framework.Chapter_1
{
    class Listing_1_38
    {
        public static void Start()
        {
            ConcurrentStack<string> stack = new ConcurrentStack<string>();
            stack.Push("Rob");
            stack.Push("Miles");
            string str;

            if (stack.TryPeek(out str))
                Console.WriteLine("Peek: {0}", str);

            if (stack.TryPop(out str))
                Console.WriteLine("Pop: {0}", str);

            Console.ReadKey();
        }
    }
}
