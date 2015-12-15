using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DynamicArray<T>
    {
        private int count;
        private T[] array;

        public DynamicArray()
        {
            this.array = new T[10];
        }

        public DynamicArray(int size)
        {
            this.array = new T[size];
        }

        public int Capacity
        {
            get { return this.array.Length; }
        }

        public int Count
        {
            get { return this.count; }
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public DynamicArray<T> Add(T item)
        {
            this.count++;
            if (this.count == this.Capacity)
            {
                T[] arr = this.array;
                this.array = new T[this.array.Length * 2];

                for (int k = 0; k < this.count; k++)
                {
                    this.array[k] = arr[k];
                }
            }
            this.array.SetValue(item, count);
            return this;
        }

        public DynamicArray<T> InsertAt(int index, T value)
        {
            while (this.array.Length < index)
            {
                T[] arr = this.array;
                this.array = new T[this.array.Length * 2];
                this.array = arr;
            }
            this.array[index] = value;
            this.count++;
            return this;
        }

        public bool Remove(T value)
        {
            //DynamicArray<T> newArr = this.array.
            return false;
        }

        public DynamicArray<T> RemoveAt(int index)
        {
            if (index > this.count)
            {
                throw new IndexOutOfRangeException();
            }
            if (this.count <= (1 / 3 * this.array.Length))
            {
                T[] arr = this.array;
                this.array = new T[this.array.Length / 2];
                this.array = arr;
            }
            this.array[index] = default(T);
            return this;
        }

        public DynamicArray<T> Clear()
        {
            for (int i = 0; i < count; i++)
            {
                this.array[i] = default(T);
            }
            return this;
        }

        public T this[int index]
        {
            get { return this.array[index]; }
            set { this.array[index] = value; }
        }

        public T[] Toarray()
        {
            T[] arr = this.array;
            return arr;
        }
    }
}
