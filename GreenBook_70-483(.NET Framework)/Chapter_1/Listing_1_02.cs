using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GreenBook_70_438.Chapter1
{
    public class Listing_1_2
    {
        // Made public so other listings can use the code
        public static void WorkOnItem(object item)
        {
            Console.WriteLine("Started working on: " + item);
            Thread.Sleep(100);
            Console.WriteLine("Finished working on: " + item);
        }

        public static void Start()
        {
            var items = Enumerable.Range(0, 500);
            Parallel.ForEach(items, item =>
            {
               WorkOnItem(item);
            });
            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }
    }
}
