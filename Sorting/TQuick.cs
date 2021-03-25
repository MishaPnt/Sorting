using System;

namespace Sorting
{
    class TQuick : TSorting
    {
        public TQuick(int[] myArray,bool sortByAsc) : base(myArray, sortByAsc)
        {
        }
        private void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        private int Partition(int[] myArray, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (sortByAsc==true)
                {
                    if (myArray[i] < myArray[maxIndex])
                    {
                        pivot++;
                        Swap(ref myArray[pivot], ref myArray[i]);
                    }
                }
                else
                {
                    if (myArray[i] > myArray[maxIndex])
                    {
                        pivot++;
                        Swap(ref myArray[pivot], ref myArray[i]);
                    }
                }
            }
            pivot++;
            Swap(ref myArray[pivot], ref myArray[maxIndex]);
            return pivot;
        }

        private int[] QuickSort(int[] myArray, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return myArray;
            }

            var pivotIndex = Partition(myArray, minIndex, maxIndex);
            QuickSort(myArray, minIndex, pivotIndex - 1);
            QuickSort(myArray, pivotIndex + 1, maxIndex);

            return myArray;
        }

        public override int[] Sort()
        {
            return QuickSort(myArray, 0, myArray.Length - 1);
        }
    }
}
