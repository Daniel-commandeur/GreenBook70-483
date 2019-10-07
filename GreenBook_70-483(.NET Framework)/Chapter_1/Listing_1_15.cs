using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GreenBook_70_438.Chapter1
{
    class Listing_1_15
    {
        public static void HelloTask(string error = null)
        {
            Thread.Sleep(1000);
            //Changed WriteLine to Write
            Console.Write("Hello ");
            
            // Added code for Listing 1-16
            if (error != null)
            {
                throw new Exception();
            }
        }

        public static void WorldTask()
        {
            Thread.Sleep(1000);
            //Changed WriteLine to Write
            Console.Write("World");
        }

        public static void Start()
        {
            Task task = Task.Run(() => HelloTask());
            task.ContinueWith((prevTask) => WorldTask());

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }
    }
}
