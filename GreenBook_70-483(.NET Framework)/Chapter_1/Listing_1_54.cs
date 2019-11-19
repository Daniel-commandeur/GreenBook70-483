using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook_70_483_.NET_Framework.Chapter_1
{
    class Listing_1_54
    {
        static int counter;
        static void Initalize()
        {
            Console.WriteLine("Initialize	called");
            counter = 0;
        }
        static void Update()
        { Console.WriteLine("Update	called");
            counter = counter + 1;
        }
        static bool Test()
        { Console.WriteLine("Test	called");
            return counter < 5;
        }
        public static void Start()
        { for ( Initalize(); Test(); Update())
            {
                Console.WriteLine("Hello	{0}", counter);
            }
            Console.ReadKey();
            Console.WriteLine("\nNow the same loop written as it is most used");
            // This Code does the same as above
            for (int counter = 0; counter < 5; counter++)
            {
                Console.WriteLine("Hello	{0}", counter);
            }
            Console.ReadKey();
        }
    }
}
