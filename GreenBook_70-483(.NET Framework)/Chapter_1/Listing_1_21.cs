using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GreenBook_70_438.Chapter1
{
    class Listing_1_21
    {
        public static void WorkOnData(object data)
        {
            Console.WriteLine("Working on: {0}", data);
            Thread.Sleep(1000);
        }
        public static void Start()
        {
            ParameterizedThreadStart ps = new ParameterizedThreadStart(WorkOnData);
            Thread thread = new Thread(ps);
            thread.Start(99);
        }

    }
}
