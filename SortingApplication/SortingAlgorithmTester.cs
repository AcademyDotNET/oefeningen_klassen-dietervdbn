using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    enum SortingAlgorithm
    {
        BubbleSort,
        ShakerSort,
        QuickSort
    }
    class SortingAlgorithmTester
    {
        ILogger consoleWriter = new ConsoleLogger();
        ISwapper Swapperke;
        public SortingAlgorithmTester(ISwapper swapper)
        {
            Swapperke = swapper;
        }
        public void Test()
        {
            var values = (SortingAlgorithm[])Enum.GetValues(typeof(SortingAlgorithm));
            foreach (var algorithm in values) 
            {
                ISortClass methode = FactorySorter.build(algorithm, Swapperke);
                int[] array = { 88, 12, 55, 105, 48, 84, 66, 35, 57, 89, 74, 106, 200, 541, 1, 9, 7, 55, 405, 13 };
                methode.Sort(array);
                consoleWriter.Print($"sorting done using {algorithm}, needed {methode.Swapped} swaps to sort the array");
            }
            Console.ReadKey();
        }
    }
}
