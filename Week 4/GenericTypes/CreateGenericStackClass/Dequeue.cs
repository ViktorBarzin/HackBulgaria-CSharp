namespace CreateGenericStackClass
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class <![CDATA[Dequeue]]> implemented via LinkedList.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    public class Dequeue<T>
    {
        /// <summary>
        /// LinkedList to save elements.
        /// </summary>
        private LinkedList<T> list = new LinkedList<T>();

        /// <summary>
        /// Clears current instance of the <![CDATA[Dequeue]]> class.
        /// </summary>
        /// <returns>The current instance of the class.</returns>
        public LinkedList<T> Clear()
        {
            this.list = new LinkedList<T>();
            return this.list;
        }

        /// <summary>
        /// Checks if the current instance of the class contains a generic type variable.
        /// </summary>
        /// <param name="item">Item to check if is present in the object.</param>
        /// <returns>True if generic item exists in the current instance of the class.</returns>
        public bool Contains(T item)
        {
            return this.list.Contains(item);
        }

        /// <summary>
        /// Remove the first element in the <![CDATA[Dequeue]]> object.
        /// </summary>
        /// <returns>The current instance of the class.</returns>
        public LinkedList<T> RemoveFromFront()
        {
            this.list.RemoveFirst();
            return this.list;
        }

        /// <summary>
        /// Removes the last element from the <![CDATA[Dequeue]]> object.
        /// </summary>
        /// <returns>The current instance of the class without the last element.</returns>
        public LinkedList<T> RemoveFromEnd()
        {
            this.list.RemoveLast();
            return this.list;
        }

        /// <summary>
        /// Adds an element to the from of the <![CDATA[Dequeue]]> object.
        /// </summary>
        /// <param name="item">Generic item to add.</param>
        /// <returns>The current instance of the class with added new first element.</returns>
        public LinkedList<T> AddToFront(T item)
        {
            this.list.AddFirst(item);
            return this.list;
        }

        /// <summary>
        /// Adds a generic item to the end of the <![CDATA[Dequeue]]> object.
        /// </summary>
        /// <param name="item">Generic item to add.</param>
        /// <returns>The current instance of the class with 1 more element at the end.</returns>
        public LinkedList<T> AddToEnd(T item)
        {
            this.list.AddLast(item);
            return this.list;
        }

        /// <summary>
        /// Returns the first element without removing it.
        /// </summary>
        /// <returns>The first element from the <![CDATA[Dequeue]]> object.</returns>
        public T PeekFromFront()
        {
            return this.list.ToList()[this.list.ToList().Count - 1];
        }

        /// <summary>
        /// Returns the last element without removing it.
        /// </summary>
        /// <returns>The last element of the <![CDATA[Dequeue]]> object.</returns>
        public T PeekFromEnd()
        {
            return this.list.ToList()[this.list.ToList().Count - 1];
        }
    }
}
