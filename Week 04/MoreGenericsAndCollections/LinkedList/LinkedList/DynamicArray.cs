namespace DataStructures
{
    using System;

    /// <summary>
    /// Generic class DynamicArray.
    /// </summary>
    /// <typeparam name="T">Generic type.</typeparam>
    public class DynamicArray<T>
    {
        /// <summary>
        /// Array to keep the elements.
        /// </summary>
        private T[] array;

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicArray{T}"/> class with default size.
        /// </summary>
        public DynamicArray()
        {
            this.array = new T[10];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicArray{T}"/> class with specified size..
        /// </summary>
        /// <param name="size">Size of the DynamicArray object.</param>
        public DynamicArray(int size)
        {
            this.array = new T[size];
        }

        /// <summary>
        /// Gets the capacity of the DynamicArray object.
        /// </summary>
        /// <value>Private setter.</value>
        public int Capacity
        {
            get { return this.array.Length; }
        }

        /// <summary>
        /// Gets the Count of elements in the DynamicArray object.
        /// </summary>
        /// <value>Private setter.</value>
        public int Count { get; private set; }

        /// <summary>
        /// Indexer for the DynamicArray object.
        /// </summary>
        /// <param name="index">Indexer for the object.</param>
        /// <returns>Indexer for the current instance.</returns>
        public T this[int index]
        {
            get { return this.array[index]; }

            set { this.array[index] = value; }
        }

        /// <summary>
        /// Checks if the object contains a generic item.
        /// </summary>
        /// <param name="item">Item to check.</param>
        /// <returns>True if items exists in the object.</returns>
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

        /// <summary>
        /// Gets the index of a specified item.
        /// </summary>
        /// <param name="item">Item to gets its index.</param>
        /// <returns>The index of the input item or -1 if not found.</returns>
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

        /// <summary>
        /// Adds element to the object.
        /// </summary>
        /// <param name="item">Item to add.</param>
        /// <returns>The current instance with add 1 more item.</returns>
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

        /// <summary>
        /// Inserts a generic type at specified index.
        /// </summary>
        /// <param name="index">Index to place the new value.</param>
        /// <param name="value">The new value to place.</param>
        /// <returns>The current instance of the class.</returns>
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

        /// <summary>
        /// Not implemented.
        /// </summary>
        /// <param name="value">Not implemented yet.</param>
        /// <returns>Not implemented so far.</returns>
        public bool Remove(T value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes an item at specified index.
        /// </summary>
        /// <param name="index">Index to remove at.</param>
        /// <returns>The current instance of the class.</returns>
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

        /// <summary>
        /// Removes all items in the object.
        /// </summary>
        /// <returns>The current instance of the class.</returns>
        public DynamicArray<T> Clear()
        {
            for (int i = 0; i < this.Count; i++)
            {
                this.array[i] = default(T);
            }

            return this;
        }

        /// <summary>
        /// Casts the DynamicArray object to array.
        /// </summary>
        /// <returns>A new generic type array.</returns>
        public T[] Toarray()
        {
            T[] arr = this.array;
            return arr;
        }
    }
}
