using System;

namespace lab3_triangle
{
    class Dialogs
    {
        public static Int64 Menu()
        {
            return ReadNumber(Strings.MainMenu + "\n");
        }

        public static TriangleModel Triangle()
        {
            Int64 a = ReadNumber(Strings.EnterSideA);
            Int64 b = ReadNumber(Strings.EnterSideB);
            Int64 c = ReadNumber(Strings.EnterSideC);
            return new TriangleModel
            {
                A = a,
                B = b,
                C = c
            };
        }

        private static Int64 ReadNumber(string message)
        {
            NumberParser parser;
            while (true)
            {
                Console.Write(message);
                parser = new NumberParser(Console.ReadLine());
                Console.WriteLine();
                if (parser.IsFloat)
                {
                    Console.WriteLine(Strings.ErrorNumberFractional);
                }
                else if (parser.IsComplex)
                {
                    Console.WriteLine(Strings.ErrorNumberComplex);
                }
                else if (parser.isInvalidInput)
                {
                    Console.WriteLine(Strings.ErrorNumberContainsInvalidSymbols);
                }
                else if (parser.IsNegative)
                {
                    Console.WriteLine(Strings.ErrorNumberNegative);
                }
                else if (parser.IsTooBig)
                {
                    Console.WriteLine(Strings.ErrorNumberTooBig);
                } else
                {
                    break;
                }
                Console.WriteLine();
            }
            return parser.Value;
        }
    }
}
