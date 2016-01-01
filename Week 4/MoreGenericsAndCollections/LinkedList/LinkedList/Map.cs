namespace DataStructures
{
    using System;

    /// <summary>
    /// Generic class Map.
    /// </summary>
    /// <typeparam name="T">First generic type.</typeparam>
    /// <typeparam name="U">Second generic type.</typeparam>
    public class Map<T, U>
    {
        /// <summary>
        /// Contains the keys for the map.
        /// </summary>
        private readonly DynamicArray<T> keys = new DynamicArray<T>();

        /// <summary>
        /// Contains the values for the map.
        /// </summary>
        private readonly DynamicArray<U> values = new DynamicArray<U>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Map{T,U}"/> class.
        /// </summary>
        /// <param name="k">Key parameter.</param>
        /// <param name="val">Value parameter.</param>
        public Map(T k, U val)
        {
            this.Key = k;
            this.Value = val;
        }

        /// <summary>
        /// Gets the Key value.
        /// </summary>
        /// <value>Setter is private.</value>
        public T Key { get; private set; }

        /// <summary>
        /// Gets the Value value.
        /// </summary>
        /// <value>Setter is private.</value>
        public U Value { get; private set; }

        /// <summary>
        /// Allows setting by indexer.
        /// </summary>
        /// <param name="i">Indexer value.</param>
        /// <returns>The current instance of the class.</returns>
        public T this[T i]
        {
            get
            {
                if (!this.keys.Contains(i))
                {
                    throw new ArgumentOutOfRangeException();
                }

                return i;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                if (this.keys.Contains(i))
                {
                    throw new ArgumentException("Element already exists");
                }
            }
        }

        /// <summary>
        /// Adds a new generic key and value elements.
        /// </summary>
        /// <param name="key">Key parameter.</param>
        /// <param name="value">Value parameter.</param>
        /// <returns>The current instance of the class.</returns>
        public Map<T, U> Add(T key, U value)
        {
            if (key.Equals(null))
            {
                throw new ArgumentNullException();
            }

            if (this.keys.Contains(key))
            {
                throw new ArgumentException("An element with the same key already exists");
            }

            this.keys.Add(key);
            this.values.Add(value);
            return this;
        }

        /// <summary>
        /// Checks if the object contains a specified key.
        /// </summary>
        /// <param name="key">Key to check.</param>
        /// <returns>True if the object contains a key with the specified value.</returns>
        public bool ContainsKey(T key)
        {
            if (this.keys.Contains(key) && !key.Equals(null))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if the object contains a specified value.
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <returns>True if the object contains a value with the specified value.</returns>
        public bool ContainsValue(U value)
        {
            if (this.values.Contains(value) && !value.Equals(null))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Removes an element with the specified key.
        /// </summary>
        /// <param name="key">Key to remove.</param>
        /// <returns>true if deletion was successful.</returns>
        public bool Remove(T key)
        {
            if (key.Equals(null))
            {
                throw new ArgumentNullException();
            }

            // TODO : implement remove operation
            throw new NotImplementedException();
        }

        /// <summary>
        /// Not implemented.
        /// </summary>
        /// <returns>Not implemented yet.</returns>
        public Map<T, U> Clear()
        {
            throw new NotImplementedException();
        }
    }
}
