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
            Console.WriteLine("This will start an infinite Loop, Use (CTRL + Break) to stop the loop\nNow press any key to start the loop...");
            Console.ReadKey();
            while (true)
            {
                Console.WriteLine("Hello!");
            }

            // The false version of this code i left out as it does not generate any Output
        }
    }
}
