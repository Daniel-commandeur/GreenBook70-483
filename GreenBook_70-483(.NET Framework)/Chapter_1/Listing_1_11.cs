using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GreenBook_70_438.Chapter1
{
    class Listing_1_11
    {
        public static void DoWork()
        {
            Console.WriteLine("Work starting");
            Thread.Sleep(2000);
            Console.WriteLine("Work finished");
        }
        public static void Start()
        {
            Task newTask = new Task(() => DoWork());
            newTask.Start();
            newTask.Wait();
        }
    }
}
