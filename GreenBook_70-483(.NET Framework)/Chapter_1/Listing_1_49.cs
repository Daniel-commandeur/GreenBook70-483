using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GreenBook_70_483_.NET_Framework.Chapter_1
{
    class Listing_1_49
    {
        static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public static void Clock()
        {
            while (!cancellationTokenSource.IsCancellationRequested)
            {
                Console.WriteLine("Tick");
                Thread.Sleep(500);
            }
        }

        public static void Clock(CancellationToken cancellationToken)
        {
            int tickCount = 0;
            while (!cancellationToken.IsCancellationRequested && tickCount < 20)
            {
                tickCount++;
                Console.WriteLine("Tick");
                Thread.Sleep(500);
            }
            cancellationToken.ThrowIfCancellationRequested();
        }


        public static void Run1()
        {
            Console.WriteLine("Press any key to start the clock and while running press any key to stop the clock");
            Console.ReadKey();
            Task.Run(() => Clock());
            Console.ReadKey();
            cancellationTokenSource.Cancel();
            Console.WriteLine("Clock stopped");
            Console.ReadKey();
        }
        public static void Run2()
        {
            Console.WriteLine("Press any key to start the clock for 20 ticks \n Then press any key to cancel while running");
            Console.ReadKey();
            Task.Run(() => Clock(cancellationTokenSource.Token));
            Console.ReadKey();
            cancellationTokenSource.Cancel();
            Console.WriteLine("Clock stopped");
            Console.ReadKey();
        }
            public static void Start()
        {
            Console.WriteLine("Press 1 to run the first bit of code or press 2 to run the seccond bit of code");
            char keyPressed = Console.ReadKey().KeyChar;
            Console.Clear();
            //Console.WriteLine(keyPressed);
            if (keyPressed == '1')
            {
                Run1();
            }
            else if (keyPressed == '2')
            {
                Run2();
            }
            else
            {
                Console.Clear();
                Start();
            }

            
        }
    }
}
