using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Map<T, U>
    {
        private T key;
        private U value;
        private DynamicArray<T> keys = new DynamicArray<T>();
        private DynamicArray<U> values = new DynamicArray<U>();

        public Map(T k, U val)
        {
            this.Key = k;
            this.Value = val;
        }

        public T Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        public U Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

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
                if (this.keys.Contains(i))
                {
                    throw new ArgumentException("Element already exists");
                }
                i = value;
            }
        }

        public Map<T, U> Add(T key, U value)
        {
            if (key.Equals(null))
            {
                throw new ArgumentNullException();
            }
            if (keys.Contains(key))
            {
                throw new ArgumentException("An element with the same key already exists");
            }
            this.keys.Add(key);
            this.values.Add(value);
            return this;
        }

        public bool ContainsKey(T key)
        {
            if (this.keys.Contains(key) && !key.Equals(null))
            {
                return true;
            }
            return false;
        }

        public bool ContainsValue(U value)
        {
            if (this.values.Contains(value) && !value.Equals(null))
            {
                return true;
            }
            return false;
        }

        public bool Remove(T key)
        {
            if (key.Equals(null))
            {
                throw new ArgumentNullException();
            }
            // TODO : implement remove operation
            throw new NotImplementedException();
        }

        public Map<T, U> Clear()
        {
            throw new NotImplementedException();
        }
    }
}
