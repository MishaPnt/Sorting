using System;

namespace Sorting
{
    class TQuick : TSorting
    {
        public TQuick(int[] myArray,bool sortByAsc,int x,int y) : base(myArray, sortByAsc,x,y)
        {
        }
        public override void Swap()
        {
            var t = myArray[x];
            myArray[x] = myArray[y];
            myArray[y] = t;
        }

        private int Partition(int[] myArray, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (sortByAsc)
                {
                    if (myArray[i] < myArray[maxIndex])
                    {
                        pivot++;
                        Swap(myArray[pivot],myArray[i]);
                    }
                }
                else
                {
                    if (myArray[i] > myArray[maxIndex])
                    {
                        pivot++;
                        Swap(myArray[pivot],myArray[i]);
                    }
                }
            }
            pivot++;
            Swap(myArray[pivot],myArray[maxIndex]);
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
