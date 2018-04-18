using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_triangle
{
    class Dialogs
    {
        public static int Menu()
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("You must enter `1` or `2`.");
            Console.WriteLine("1: Compare sides.");
            Console.WriteLine("2: Exit.");
            return ReadNumber();
        }

        public static TriangleModel Triangle()
        {
            Console.WriteLine("Enter the first side A: ");
            int a = ReadNumber();
            Console.WriteLine("Enter the second side B: ");
            int b = ReadNumber();
            Console.WriteLine("Enter the third side B: ");
            int c = ReadNumber();
            return new TriangleModel
            {
                A = a,
                B = b,
                C = c
            };
        }

        private static int ReadNumber()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
