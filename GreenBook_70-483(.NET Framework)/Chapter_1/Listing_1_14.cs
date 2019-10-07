using System;
using System.Threading;
using System.Threading.Tasks;

namespace GreenBook_70_438.Chapter1
{
    class Listing_1_14
    {
        public static void DoWork(int i)
        {
            Console.WriteLine($"Task {i} starting");
            Thread.Sleep(2000);
            Console.WriteLine($"Task {i} finished");
        }
        public static void Start()
        {
            Task[] Tasks = new Task[10];
            for (int i = 0; i < 10; i++)
            {
                int taskNum = i;    //	make a local copy of the loop counter so that the
                                    //	correct	task number is passed into the lambda expression
                Tasks[i] = Task.Run(() => DoWork(i));
            }
            Task.WaitAll(Tasks);
            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }
    }
}