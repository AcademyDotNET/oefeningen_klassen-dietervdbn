using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    public class QuickSort : SortClass
    {
        private ISwapper _swapper;
        public override int Swapped { get; set; } = 0;
        public QuickSort(ISwapper swap)
        {
            _swapper = swap;
        }
        public override void Sort(int[] array)
        {
            QuickSortArray(array, 0, array.Length - 1);
        }
        void QuickSortArray(int[] array, int Left, int Right)
        {
            int L = Left;
            int R = Right;
            int pivotValue = array[(Left + Right) / 2];

            do
            {
                while (array[L] < pivotValue)
                {
                    L++;
                }
                while (pivotValue < array[R])
                {
                    R--;
                }

                if (L <= R)
                {
                    _swapper.Swap(L, R, array);
                    Swapped++;
                    L++;
                    R--;
                }
            } while (L < R);

            if (Left < R)
            {
                QuickSortArray(array, Left, R);
            }
            if (L < Right)
            {
                QuickSortArray(array, L, Right);
            }
        }
    }
}
