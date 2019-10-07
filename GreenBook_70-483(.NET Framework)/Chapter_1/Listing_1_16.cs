using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GreenBook_70_438.Chapter1
{
    // TODO Make this ignore the exception thrown with try/catch or something, should run without stopping the program but giving a exception
    class Listing_1_16
    {
        public static void Start()
        {
            // Added a parameter in the HelloTask() method to trigger a exception
            Task task = Task.Run(() => Listing_1_15.HelloTask("1"));

            task.ContinueWith((prevTask) => Listing_1_15.WorldTask(), TaskContinuationOptions.OnlyOnRanToCompletion);

            task.ContinueWith((prevTask) => ExceptionTask(), TaskContinuationOptions.OnlyOnFaulted);
        }

        // Added because there was no ExceptionTask
        private static void ExceptionTask()
        {
            Console.WriteLine("***************The Task Failed******************");
        }
    }
}
