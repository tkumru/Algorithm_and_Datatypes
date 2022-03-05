using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_and_Collections.Array
{
    public class Array<T> : IEnumerable<T>, ICloneable
    {
        private T[] InnerList;  // build data organization on this list
        public int Count { get; private set; }  // readable from out , writable only in
        public int Capacity => InnerList.Length;

        public Array()
        {
            InnerList = new T[2];  // set capacity
            Count = 0;  // set count
        }

        public Array(params T[] initial)
        {
            InnerList = new T[initial.Length];
            Count = 0;

            foreach (var item in initial)
            {
                Add(item);
            }
        }

        public Array(IEnumerable<T> collection)
        {
            InnerList = new T[collection.ToArray().Length];
            Count = 0;

            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public void Add(T item){
            if (InnerList.Length == Count)
            {       
                DoubleArray();
            }
            InnerList[Count] = item;
            Count++;
        }

        private void DoubleArray()
        {
            var temp = new T[InnerList.Length * 2];  // new list

            System.Array.Copy(InnerList, temp, InnerList.Length);  // source = Innerlist, copy to temp in, copy to how many variable

            InnerList = temp;
        }

        public T Remove(){  // remove last element default, return removed element 
            if(Count == 0){
                throw new Exception("There is no element in array for removing");
            }

            if (InnerList.Length / 4 == Count)
            {
                HalfArray();
            }

            var temp = InnerList[Count - 1];  // count_indexing.jpg

            if (Count > 0)
            {
                Count--;
            }

            return temp;
        }

        private void HalfArray()
        {
            if (InnerList.Length > 2)   
            {
                var temp = new T[InnerList.Length / 2];

                System.Array.Copy(InnerList, temp, temp.Length);

                InnerList = temp;
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return InnerList.Take(Count).GetEnumerator();  // If we use select instead of take, print array with zero so space references
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
