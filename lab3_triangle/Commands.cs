using System;
using System.Linq;
using System.Windows.Forms;

namespace lab3_triangle
{
    class Commands
    {
        public static void ExecuteCommand(Int64 command)
        {
            if (command == 1)
            {
                var triangle = Dialogs.Triangle();
                DefineTriangle(triangle);
                if (triangle.Valid)
                {
                    DrawTriangle(triangle);
                }
            }
        }

        private static void DefineTriangle(TriangleModel triangle)
        {
            if(triangle.Valid)
            {
                if(triangle.isEqualeteral)
                {
                    Console.WriteLine(Strings.EquilateralTriangle);
                } else if (triangle.isIsocseless)
                {
                    Console.WriteLine(Strings.IsoscelesTriangle);
                } else if (triangle.isVersatile)
                {
                    Console.WriteLine(Strings.VersatileTriangle);
                }
            } else
            {
                Console.WriteLine(Strings.InfoBadTriangle);
            }
            Console.WriteLine();
        }

        private static void DrawTriangle(TriangleModel triangle)
        {
            Int64[] abc = { triangle.A, triangle.B, triangle.C };
            Int64 height = abc.Min();
            Int64 width = abc.Max();
            int leftSpaces = 0;
            int rightSpaces = 0;
            for(int i = 0; width-leftSpaces-rightSpaces > 0; ++i)
            {
                for(int j = 0; j<leftSpaces; ++j)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j<width-leftSpaces-rightSpaces; ++j)
                {
                    Console.Write("*");
                }
                for(int j = 0; j<rightSpaces; ++j)
                {
                    Console.Write(" ");
                }
                leftSpaces++;
                rightSpaces++;
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
