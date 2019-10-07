using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GreenBook_70_438.Chapter1
{
    class Listing_1_22
    {
        public static void Start()
        {
            Thread thread = new Thread((data) => 
            {
                Listing_1_21.WorkOnData(data);
            });

            thread.Start(99);
        }
    }
}
