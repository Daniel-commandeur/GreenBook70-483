using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook_70_483_.NET_Framework.Chapter_1
{
    class Listing_1_55
    {
        public static void Start()
        {
            string[] names = { "Rob", "Mary", "David", "Jenny", "Chris", "Imogen" };
            for (int index = 0; index < names.Length; index++)
            {
                Console.WriteLine(names[index]);
            }
            Console.ReadKey();
        }
    }
}
