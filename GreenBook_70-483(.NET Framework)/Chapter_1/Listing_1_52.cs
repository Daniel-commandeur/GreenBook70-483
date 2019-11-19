using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook_70_483_.NET_Framework.Chapter_1
{
    class Listing_1_52
    {
        public static void Start()
        {
            Console.WriteLine("Press the number of the code you want to run...\n" +
                "Press 1 for the Whileloop with the True parameter\n" +
                "Press 2 for the Whileloop with the Counter parameter");

            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    Console.WriteLine("\n");
                    RunTrueWhile();
                    break;
                case '2':
                    Console.WriteLine("\n");
                    RunCounterWhile();
                    break;
                default:
                    break;
            }
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        public static void RunTrueWhile()
        {
            Console.WriteLine("This will start an infinite Loop, Use (CTRL + Break) to stop the loop\nNow press any key to start the loop...");
            Console.ReadKey();
            while (true)
            {
                Console.WriteLine("Hello!");
            }
        }
        // Code to show that this gives a Unreachable warning
        public static void RunFalseWhile()
        {
            while (false)
            {
                Console.WriteLine("Hello");
            }

        }

        public static void RunCounterWhile()
        {
            int count = 0;
            while (count < 10)
            {
                Console.WriteLine("Hello	{0}", count);
                count = count + 1;
            }
        }
    }
}
