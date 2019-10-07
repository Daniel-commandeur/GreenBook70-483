using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook_70_483_.NET_Framework.Chapter_1
{
    class Listing_1_41
    {
        // make an array that holds the values 0 to 50000000
        static int[] items = Enumerable.Range(0, 50000001).ToArray();
        public static void Start()
        {
            long total = 0;

            for (int i = 0; i < items.Length; i++)
                total = total + items[i];

            Console.WriteLine("The total is: {0}", total);
            Console.ReadKey();
        }
    }
}
