using System;

namespace Sorting
{
    class TQuick : TSorting
    {
        public TQuick(int[] myArray) : base(myArray)
        {
        }
        public override int[] Sort()
        {
            int i, j, pivot, counter, temp;

            counter = 1;         
            while (counter != 0)
            {
                i = -1;                                    
                j = 0;                            
                counter = 0;                             
                Random rand = new Random();
                pivot = rand.Next(0, myArray.Length - 1);        

                for (int x = 0; x < myArray.Length; x++)          
                {
                    if (myArray[pivot] > myArray[j])                    
                    {
                        i++;                               
                        temp = myArray[j];
                        myArray[j] = myArray[i];
                        myArray[i] = temp;                       
                        j++;                                
                        counter++;                          
                    }
                    else j++;                         
                }
                temp = myArray[i + 1];
                myArray[i + 1] = myArray[pivot];                        

                for (int x = (i + 2); x < myArray.Length; x++)        
                {
                    temp = myArray[x];
                    myArray[x + 1] = temp;
                }
            }
            return myArray;
        }
    }
}
