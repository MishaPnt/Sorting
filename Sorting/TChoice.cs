namespace Sorting
{
    class TChoice : TSorting
    {
        public TChoice(int[] myArray, bool sortByAsc) : base(myArray, sortByAsc)
        {
        }
        public override int[] Sort()
        {
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (sortByAsc)
                    {
                        if (myArray[j] < myArray[min])
                        {
                            min = j;
                        }
                    }
                    else
                    {
                        if (myArray[j] > myArray[min])
                        {
                            min = j;
                        }
                    }

                }
                Swap(ref myArray[i], ref myArray[min]);
            }
            return myArray;
        }
    }
}

