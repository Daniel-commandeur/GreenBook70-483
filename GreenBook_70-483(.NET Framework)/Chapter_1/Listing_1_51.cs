using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook_70_483_.NET_Framework.Chapter_1
{
    class Listing_1_51
    {
        // All code in class Listing_1_51 is written to make the code from the book (class Counter) show results
        public static void Start()
        {
            string runAgain = "y";
            while (runAgain == "y")
            {
                RunTask();
                Console.WriteLine($"Press 'Y' to run again");
                runAgain = Console.ReadKey().KeyChar.ToString().ToLower();
            }
        }

        public static  void RunTask()
        {
            Counter counter = new Counter();
            for (int i = 0; i < 10000; i++)
            {
                Task.Run(() => { counter.IncreaseCounter(1); });
            }

            Console.WriteLine("The total is: {0}", counter.Total);
        }
    }
    public class Counter
    {
        private int totalValue = 0;
        public void IncreaseCounter(int amount)
        {
            totalValue = totalValue + amount;
        }
        public int Total
        {
            get
            {
                return totalValue;
            }
        }
    }
}
