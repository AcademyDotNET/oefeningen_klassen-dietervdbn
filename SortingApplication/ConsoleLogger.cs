using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class ConsoleLogger : ILogger
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintSameLine(string message)
        {
            Console.Write(message);
        }
    }
}
