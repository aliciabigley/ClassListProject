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
        int value;
        int numberItemsInArray;
        int maxIndex;
        int indexerSlot;
        T[] masterArray;
        T[] temporaryArray;


        public ListAttrubutes()
        {
            maxIndex = 5;
            masterArray = new T[maxIndex];
            temporaryArray = new T[0];
        }
        public int MaxIndex
        {
            get
            {
                return maxIndex;
            }
            set
            {
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

        public T this [int number] //you are here
        {
                get
                {
                return masterArray[number];
                }
                set
                {
                masterArray[number] = value;
                }
            }
        public void CreateLargerArray() 
        {
            T[] temporaryArray = new T[maxIndex * 2];
            for (int i = 0; i < numberItemsInArray; i++)
            {
                temporaryArray[i] = masterArray[i];
            }
            maxIndex = maxIndex * 2;
            masterArray = temporaryArray;

        }
        public void Add(T item)
        {
            if (numberItemsInArray == MaxIndex)
            {
                CreateLargerArray();
            }
            masterArray[numberItemsInArray] = item;
            numberItemsInArray++;
            //for (int i = 0; i < numberItemsInArray; i++)
            //{
            //    Console.WriteLine(NumberItemsInArray);
            //}
        }
        public bool Remove(T item)//add temp array
        {
            masterArray[maxIndex] = item;
            for (int i = 0; i < numberItemsInArray; i++)
            {
                if (masterArray[i].Equals(item))
                {
                    masterArray[i] = masterArray[i + 1];
                    numberItemsInArray--;
                    return true;
                }
            }
            return false;
        }
//        public IEnumerator.GetEnumerator(T item)
//        {
//          masterArray[maxIndex]
//          for (int i = 0; i<masterArray.maxIndex; i++)
//            {
//                if (masterArray[i] == null)
//                {
//                    yield return i;

//                }
//            }
//         }
        public static ListAttrubutes<T> operator +(ListAttrubutes<T> attrubutesOne, ListAttrubutes<T> attrubutesTwo)
        {
        ListAttrubutes<T> addTwoListsTogether = new ListAttrubutes<T>();
            addTwoListsTogether = attrubutesOne + attrubutesTwo;
            return addTwoListsTogether;
        }
        public static ListAttrubutes<T> operator -(ListAttrubutes<T> attrubutesOne, ListAttrubutes<T> attrubutesTwo)
        {
            ListAttrubutes<T> subtractItems = new ListAttrubutes<T>();
            subtractItems = attrubutesOne - attrubutesTwo;
            return subtractItems;
        }
    }
}
//check for empty spots
//create larger array
//copy from first(old) array
//add items from in first open spot in new array
//update maxIndex and numberOfItemsInArray