using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_triangle
{
    class Menu
    {
        public static void Print()
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("You must enter `1` or `2`.");
            Console.WriteLine("1: Compare sides.");
            Console.WriteLine("2: Exit.");
        }

        public static int Read()
        {
            return 0;
        }
    }
}
