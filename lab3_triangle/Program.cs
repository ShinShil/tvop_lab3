using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int command;
            do
            {
                Menu.Print();
                command = Menu.Read();
                Commands.ExecuteCommand(command);
            } while (command != 2);
        }
    }
}
