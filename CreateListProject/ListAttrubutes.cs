using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateListProject
{
    public class ListAttrubutes<T> //: IEnumerable
    {
        int addValue;
        int numberItemsInArray;
        int maxIndex;
        T[] masterArray;
        T[] temporaryArray;


        public ListAttrubutes()
        {
            numberItemsInArray = 0;
            maxIndex = 5;
            masterArray = new T[maxIndex];
            temporaryArray = new T[maxIndex];
        }
        public int MaxIndex
        {
            get
            {
                return maxIndex;
            }
            set
            {
                if(value == 5)
                {
                    maxIndex = value * 2;
                }
                maxIndex = value;
            }
        }
        public int NumberItemsInArray
        {
            get
            {
                return numberItemsInArray;
            }

        }
         public void CreateLargerArray()//you are here
        {
            if (maxIndex < 5)
            {
                Console.WriteLine(NumberItemsInArray);
            }

            temporaryArray = masterArray;

        }
        public void ObjectToBeAddedArray(T item) //Need to test
        {
            for (int i = 0; i < numberItemsInArray; i++)
            {
                
            }

        }

        public void AddObject(T numberItemsInArray)
        {

          
        }
        public void ObjectsToBeRemoverFromArray() //Need to Test
        {
            for (int i = 0; i < numberItemsInArray; i++)
            {
                return;
            }
        }

       
        //public IEnumerator GetEnumerator()
        //{

        //    masterArray[maxIndex]
        //  for (int i = 0; i < masterArray.maxIndex; i++)
        //    {
        //        if (masterArray[i] == null)
        //        {
        //            yield return i;

        //        }
        //    }

        //}
    }
}
//check for empty spots
//create larger array
//copy from first(old) array
//add items from in first open spot in new array
//update maxIndex and numberOfItemsInArray