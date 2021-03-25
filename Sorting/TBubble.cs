using System;

namespace Sorting
{
    class TBubble : TSorting
    {
        public TBubble(int[] myArray, bool sortByAsc) : base(myArray, sortByAsc)
        {
        }
        public override int[] Sort()
        {
            int temp;
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (sortByAsc)
                    {
                        if (myArray[i] > myArray[j])
                        {
                            temp = myArray[i];
                            myArray[i] = myArray[j];
                            myArray[j] = temp;
                        }
                    }
                    else
                    {
                        if (myArray[i] < myArray[j])
                        {
                            temp = myArray[i];
                            myArray[i] = myArray[j];
                            myArray[j] = temp;
                        }
                    }

                }
            }
            return myArray;
        }
    }
}
