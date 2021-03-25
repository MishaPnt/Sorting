namespace Sorting
{
    class TChoice : TSorting
    {
        public TChoice(int[]myArray,bool sortByAsc) :base(myArray, sortByAsc)
        {
        }
        public override int[] Sort()
        {
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (sortByAsc == true)
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
                int temp = myArray[min];
                myArray[min] = myArray[i];
                myArray[i] = temp;
            }
            return myArray;
        }
    }
}

