using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook_70_483_.NET_Framework.Chapter_1
{
    class Listing_1_35
    {
        public static void Start()
        {
            // Blocking collection that can hold 5 items
            BlockingCollection<int> data = new BlockingCollection<int>(5);
            Task.Run(() =>
            {
                // attempt to add 10 items to the collection - blocks after 5th
                for (int i = 0; i < 11; i++)
                {
                    data.Add(i);
                    Console.WriteLine("Data {0} added sucessfully.", i);
                }
                // indicate we have no more to add
                data.CompleteAdding();
            });
            Console.ReadKey();
            Console.WriteLine("Reading collection");
            Task.Run(() =>
            {
                while (!data.IsCompleted)
                {
                    try
                    {
                        int v = data.Take();
                        Console.WriteLine("Data {0} taken sucessfully.", v);
                    }
                    catch (InvalidOperationException) { }
                }
            }); Console.ReadKey();
        }
    }
}
