using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateListProject
{
    public class ListAttrubutes<T> : IEnumerable
    {
        int count;
        int capacity;
        string array;
        T[] masterArray;
        T[] temporaryArray;


        public ListAttrubutes()
        {
            capacity = 5;
            masterArray = new T[capacity];
            temporaryArray = new T[0];
        }
        public int MaxIndex
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }

        }

        public T this[int number]
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
            T[] temporaryArray = new T[capacity * 2];
            for (int i = 0; i < count; i++)
            {
                temporaryArray[i] = masterArray[i] ;
            }
            capacity = capacity * 2;
            masterArray = temporaryArray;

        }
        public void Add(T item)
        {
            if (count == MaxIndex)
            {
                CreateLargerArray();
            }
            masterArray[count] = item;
            count++;
        }
        //public void Insert(T item)
        //{
        //    for (int i = 0; i < MaxIndex; i++)
        //    {
        //        Add(item);
        //    }
        //}
        //masterArray[numberItemsInArray] = item;
        //numberItemsInArray++;

        public bool Remove(T item) 
        {
            for (int i = 0; i < count; i++)
            {
                if (masterArray[i].Equals(item))
                {
                    masterArray[i] = masterArray[i + 1];
                    count++;
                    return true;
                }

            }
            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return masterArray[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        //you are here
        public string ToString()
        {

            for (int i = 0; i < masterArray.Length; i++)
            {
                array = array + " " + masterArray[i];
            }
            return array;
        }

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



//public int? Count()
//{
//    int length = count;
//    if (length == 0)
//    {
//        return null;
//    }

//    else
//    {
//        for (int i = 0; i < count; i++)
//        {
//            length = count;
//        }
//        return length;
//    }
//}


//}



//}
//check for empty spots
//create larger array
//copy from first(old) array
//add items from in first open spot in new array
//update maxIndex and numberOfItemsInArray