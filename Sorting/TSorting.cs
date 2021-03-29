namespace Sorting
{
    abstract class TSorting
    {
        public abstract int[] Sort();

        protected int[] myArray;
        protected bool sortByAsc;
        protected  int x;
        protected  int y;
        public TSorting(int[] myArray,bool sortByAsc,int x,int y)
        {
            this.myArray = myArray;
            this.sortByAsc = sortByAsc;
            this.x = x;
            this.y = y;
        }
        protected void Swap()
        {
            var t = myArray[x];
            myArray[x] = myArray[y];
            myArray[y] = t;
        }
    }
}
