using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FixedSizeList<T>
    {
        public T[] Elements { get; set; }
        public int Capacity { get; set; }
        public int Count { get; set; }
        public FixedSizeList(int capacity) 
        { 
           Capacity = capacity;
           Elements = new T[capacity];
           Count = 0;
        }

        public void Add(T item) 
        {
            if (Count >= Capacity)
               throw new Exception("List is full");
            else
                Elements[Count] = item;
                Count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new Exception("Index is out of range.");
            }
            return Elements[index];
        }
    }
}
