namespace Sorting
{
    abstract class TSorting
    {
        public abstract int[] Sort();

        protected int[] myArray;
        protected bool sortByAsc;
        public TSorting(int[] myArray,bool sortByAsc)
        {
            this.myArray = myArray;
            this.sortByAsc = sortByAsc;
        }
    }
}
