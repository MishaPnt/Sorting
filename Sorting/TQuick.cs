using System;

namespace Sorting
{
    class TQuick : TSorting
    {
        public TQuick(int[] myArray,bool sortByAsc,int x,int y) : base(myArray, sortByAsc,x,y)
        {
        }

        private int Partition(int[] myArray, int minIndex, int maxIndex)
        {
            var x = minIndex - 1;
            for (var y = minIndex; y < maxIndex; y++)
            {
                if (sortByAsc)
                {
                    if (myArray[y] < myArray[maxIndex])
                    {
                        x++;
                        Swap();
                    }
                }
                else
                {
                    if (myArray[y] > myArray[maxIndex])
                    {
                        x++;
                        Swap();
                    }
                }
            }
            x++;
            Swap();
            return x;
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
