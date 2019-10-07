using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GreenBook_70_438.Chapter1
{
    class Listing_1_17
    {
        public static void DoChild(object state)
        {
            Console.WriteLine("Child {0} starting", state);
            Thread.Sleep(2000);
            Console.WriteLine("Child {0} finished", state);
        }
        public static void Start()
        {
            var parent = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Parent starts");
                for (int i = 0; i < 10; i++)
                {
                    int taskNo = i;
                    Task.Factory.StartNew((x) => DoChild(x), // lambda expression                               
                        taskNo, // state object
                        TaskCreationOptions.AttachedToParent);
                }
            });

            parent.Wait(); // will wait for all the attached children to complete

            Console.WriteLine("Parent finished. Press a key to end.");
            Console.ReadKey();
        }
    }
}
