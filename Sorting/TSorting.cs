using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    abstract class TSorting
    {
        public abstract int[] Sort();

        protected int[] myArray;
        public TSorting(int[] myArray)
        {
            this.myArray = myArray;
        }
    }
}
