using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class FactorySorter
    {
        public static ISortClass build(SortingAlgorithm algorithm, ISwapper swapper )
        {
            ISortClass methode = (ISortClass)Activator.CreateInstance(Type.GetType($"SortingApplication.{algorithm}"), swapper);
            return methode;
        }
    }
}
