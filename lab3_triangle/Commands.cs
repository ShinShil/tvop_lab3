using System;

namespace lab3_triangle
{
    class Commands
    {
        public static void ExecuteCommand(Int64 command)
        {
            if (command == 1)
            {
                DefineTriangle(Dialogs.Triangle());
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
    }
}
