using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FixedSizeList<T>
    {
        private T[] items; // مصفوفة لتخزين العناصر
        private int count; // عدد العناصر الحالية في القائمة
        private int capacity; // السعة القصوى للقائمة

        // Constructor
        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than 0.");
            }

            this.capacity = capacity;
            items = new T[capacity];
            count = 0;
        }

        // Method to add an item to the list
        public void Add(T item)
        {
            if (count >= capacity)
            {
                throw new InvalidOperationException("Cannot add more items. The list is full.");
            }

            items[count] = item;
            count++;
        }

        // Method to get an item at a specific index
        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range. Valid range is 0 to {count - 1}.");
            }

            return items[index];
        }

        // Property to get the current count of items
        public int Count
        {
            get { return count; }
        }

        // Property to get the capacity of the list
        public int Capacity
        {
            get { return capacity; }
        }
    }
}
