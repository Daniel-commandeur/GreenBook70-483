using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook_70_438.Chapter1
{
    class Listing_1_12
    {
        public static void Start()
        {
            Task newTask = Task.Run(() => Listing_1_11.DoWork());
            newTask.Wait();
        }
    }
}
