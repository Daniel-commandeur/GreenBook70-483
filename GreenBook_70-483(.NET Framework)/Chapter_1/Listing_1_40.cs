﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook_70_483_.NET_Framework.Chapter_1
{
    class Listing_1_40
    {
        public static void Start()
        {
            ConcurrentDictionary<string, int> ages = new ConcurrentDictionary<string, int>();

            if (ages.TryAdd("Rob", 21))
                Console.WriteLine("Rob added successfully.");

            Console.WriteLine("Rob's age: {0}", ages["Rob"]);
            
            // Set Rob's age to 22 if it is 21
            if (ages.TryUpdate("Rob", 22, 21))
                Console.WriteLine("Age updated successfully");

            Console.WriteLine("Rob's new age: {0}", ages["Rob"]);
            
            // Increment Rob's age atomically using factory method
            Console.WriteLine("Rob's age updated to: {0}", ages.AddOrUpdate("Rob", 1, (name, age) => age = age + 1));
            Console.WriteLine("Rob's new age: {0}", ages["Rob"]);
        }
    }
}
