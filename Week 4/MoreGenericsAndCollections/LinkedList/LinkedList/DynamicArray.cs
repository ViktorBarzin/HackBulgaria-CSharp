namespace DataStructures
{
    using System;

    public class DynamicArray<T>
    {
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

        public int Count { get; private set; }

        public T this[int index]
        {
            get { return this.array[index]; }

            set { this.array[index] = value; }
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
            this.Count++;
            if (this.Count == this.Capacity)
            {
                T[] arr = this.array;
                this.array = new T[this.array.Length * 2];

                for (int k = 0; k < this.Count; k++)
                {
                    this.array[k] = arr[k];
                }
            }

            this.array.SetValue(item, this.Count);
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
            this.Count++;
            return this;
        }

        public bool Remove(T value)
        {
            // DynamicArray<T> newArr = this.array.
            return false;
        }

        public DynamicArray<T> RemoveAt(int index)
        {
            if (index > this.Count)
            {
                throw new IndexOutOfRangeException();
            }

            if (this.Count <= (1 / 3 * this.array.Length))
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
            for (int i = 0; i < this.Count; i++)
            {
                this.array[i] = default(T);
            }

            return this;
        }

        public T[] Toarray()
        {
            T[] arr = this.array;
            return arr;
        }
    }
}
