using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GreenBook_70_438.Chapter1
{
    class Listing_1_19
    {
        public static void Start()
        {
            ThreadStart ts = new ThreadStart(Listing_1_18.ThreadHello);
            Thread thread = new Thread(ts);
            thread.Start();
        }
    }
}
