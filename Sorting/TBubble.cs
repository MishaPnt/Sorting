using System;

namespace Sorting
{
    class TBubble : TSorting
    {
        public TBubble(int[] myArray, bool sortByAsc, int x, int y) : base(myArray, sortByAsc, x, y)
        {
        }
        public override void Swap()
        {
            var t = myArray[x];
            myArray[x] = myArray[y];
            myArray[y] = t;
        }
        public override int[] Sort()
        {
            for ( x = 0; x < myArray.Length - 1; x++)
            {
                for ( y = x + 1; y < myArray.Length; y++)
                {
                    if (sortByAsc)
                    {
                        if (myArray[x] > myArray[y])
                        {
                            Swap();
                        }
                    }
                    else
                    {
                        if (myArray[x] < myArray[y])
                        {
                            Swap();
                        }
                    }

                }
            }
            return myArray;
        }
    }
}
