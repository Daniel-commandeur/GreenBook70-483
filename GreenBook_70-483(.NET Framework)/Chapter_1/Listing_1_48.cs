﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GreenBook_70_483_.NET_Framework.Chapter_1
{
    class Listing_1_48
    {
        static long sharedTotal;
        // make an array that holds the values 0 to 5000000
        static int[] items = Enumerable.Range(0, 500001).ToArray();

        static object sharedTotalLock = new object();
        static void addRangeOfValues(int start, int end)
        {
            long subTotal = 0;
            while (start < end)
            {
                subTotal = subTotal + items[start];
                start++;
            }
            Interlocked.Add(ref sharedTotal, subTotal);
        }

        public static void Start()
        {
            List<Task> tasks = new List<Task>();
            int rangeSize = 1000;
            int rangeStart = 0;
            while (rangeStart < items.Length)
            {
                int rangeEnd = rangeStart + rangeSize;
                if (rangeEnd > items.Length)
                    rangeEnd = items.Length;
                // create local copies of the parameters
                int rs = rangeStart;
                int re = rangeEnd;
                tasks.Add(Task.Run(() => addRangeOfValues(rs, re)));
                rangeStart = rangeEnd;
            }
            Task.WaitAll(tasks.ToArray());

            Console.WriteLine("The total is: {0}", sharedTotal);
            Console.ReadKey();
        }
    }
}
