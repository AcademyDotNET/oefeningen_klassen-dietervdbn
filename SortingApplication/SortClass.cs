﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    public abstract class SortClass: ISortClass
    {
        public abstract int Swapped { get; set; }
        public abstract void Sort(int[] array);
    }
}
