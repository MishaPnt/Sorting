namespace Sorting
{
    class TChoice : TSorting
    {
        public TChoice(int[] myArray, bool sortByAsc, int x, int y) : base(myArray, sortByAsc, x, y)
        {
        }
        public override int[] Sort()
        {
            for (y = 0; y < myArray.Length - 1; y++)
            {
                x = y;
                for (int j = y + 1; j < myArray.Length; j++)
                {
                    if (sortByAsc)
                    {
                        if (myArray[j] < myArray[x])
                        {
                            x = j;
                        }
                    }
                    else
                    {
                        if (myArray[j] > myArray[x])
                        {
                            x = j;
                        }
                    }

                }
                Swap();
            }
            return myArray;
        }
    }
}

