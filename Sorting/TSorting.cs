namespace Sorting
{
    abstract class TSorting
    {
        public abstract int[] Sort();
        public abstract void Swap();

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
    }
}
