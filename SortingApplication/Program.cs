using System;

namespace SortingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ISwapper swapper = new Swapper();
               SortingAlgorithmTester tester = new SortingAlgorithmTester(swapper);
            tester.Test();
        }
    }
}
