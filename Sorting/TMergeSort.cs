namespace Sorting
{
    class TMergeSort : TSorting
    {
        public TMergeSort(int[] myArray, bool sortByAsc) : base(myArray, sortByAsc)
        {
        }
        private void Merge(int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (sortByAsc)
                {
                    if (myArray[left] < myArray[right])
                    {
                        tempArray[index] = myArray[left];
                        left++;
                    }
                    else
                    {
                        tempArray[index] = myArray[right];
                        right++;
                    }
                }
                else
                {
                    if (myArray[left] > myArray[right])
                    {
                        tempArray[index] = myArray[left];
                        left++;
                    }
                    else
                    {
                        tempArray[index] = myArray[right];
                        right++;
                    }
                }
                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = myArray[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = myArray[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                myArray[lowIndex + i] = tempArray[i];
            }
        }

        private int[] MergeSort(int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                Swap(ref myArray[lowIndex],ref myArray[middleIndex]);
                Swap(ref myArray[middleIndex + 1],ref myArray[highIndex]);
                Merge(myArray[lowIndex], myArray[middleIndex], myArray[highIndex]);
            }
            return myArray;
        }

        public override int[] Sort()
        {
            return MergeSort(0, myArray.Length - 1);
        }

    }
}
