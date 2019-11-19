using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook_70_483_.NET_Framework.Chapter_1
{
    class Listing_1_53
    {
        public static void Start()
        {
            //Code written to make the Listing Work
            Console.WriteLine("Press the number of the code you want to run...\n" +
                "Press 1 To run a do-while loop with a false parameter\n" +
                "Press 2 To run a do-while loop that is controlled by a method");

            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    Console.WriteLine("\n");
                    DoWhileFalse();
                    break;
                case '2':
                    Console.WriteLine("\n");
                    Console.WriteLine($"Before the do-while loop the list is filled with {Numbers.Count} elemets");
                    GetDataDoWhileLoop();
                    Console.WriteLine("\nAs you can see the code runs one last time after the list is empty...");
                    break;
                default:
                    break;
            }
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }
        // Listing 1 53
        public static void DoWhileFalse()
        {
            do
            {
                Console.WriteLine("Hello");
            }
            while (false);
        }

        // Listing 1 53
        public static void GetDataDoWhileLoop()
        {
            do
            {
                RequestData();
            }
            while (!DataValid());

        }

        //Code written to make the Listing Work
        private static string number;
        private static List<string> Numbers = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private static bool DataValid()
        {
            // Pointless Code just to return a bool if the variable number is filled or not
            return !(int.TryParse(number, out int num));
        }

        private static void RequestData()
        {
            number = Numbers.FirstOrDefault();
            Console.WriteLine($"Taken the number: {number} out of the List");
            Numbers.Remove(number);
        }
    }
}
