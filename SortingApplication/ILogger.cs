using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    interface ILogger
    {
        public void Print(string message);
        public void PrintSameLine(string message);
    }
}
