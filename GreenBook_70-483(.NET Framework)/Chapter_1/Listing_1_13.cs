using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GreenBook_70_438.Chapter1
{
    class Listing_1_13
    {
        public static int CalculateResult()
        {
            Console.WriteLine("Work starting");
            Thread.Sleep(2000);
            Console.WriteLine("Work finished");
            return 99;
        }
        public static void Start()
        {
            Task<int> task = Task.Run(() =>
            {
                return CalculateResult();
            });
            Console.WriteLine(task.Result);
            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }
    }
}
