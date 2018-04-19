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
            Int64 command;
            do
            {
                command = Dialogs.Menu();
                Commands.ExecuteCommand(command);
            } while (command != 2);
        }
    }
}
