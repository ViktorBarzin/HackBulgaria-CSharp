namespace DataStructures
{
    using System;

    /// <summary>
    /// Generic class Linked List.
    /// </summary>
    /// <typeparam name="T">Generic type.</typeparam>
    public class LinkedList<T>
    {
        /// <summary>
        /// Gets or sets the Head of the linked-list.
        /// </summary>
        /// <value>Setter is private.</value>
        private Node Head { get; set; }

        /// <summary>
        /// Adds a new value to the LinkedList.
        /// </summary>
        /// <param name="value">Value to add.</param>
        /// <returns>The current instance of the class.</returns>
        public LinkedList<T> Add(T value)
        {
            if (this.Head.Equals(null))
            {
                this.Head = new Node(value, null);
                return this;
            }

            Node next = this.Head;
            while (!next.Next.Equals(null))
            {
                next = next.Next;
            }

            return this;
        }

        /// <summary>
        /// Inserts a value after a specified key.
        /// </summary>
        /// <param name="key">Key element.</param>
        /// <param name="value">Value to insert.</param>
        /// <returns>The current instance of the class.</returns>
        public LinkedList<T> InsertAfter(T key, T value)
        {
            Node insert = this.Head;
            insert.Value = value;
            while (!insert.Equals(null) && !insert.Value.Equals(key))
            {
                insert = insert.Next;
            }

            insert.Next = new Node(value, insert.Next);
            return this;
        }

        /// <summary>
        /// Inserts a value before a specified key.
        /// </summary>
        /// <param name="key">Key element.</param>
        /// <param name="value">Value to insert.</param>
        /// <returns>The current instance of the class.</returns>
        public LinkedList<T> InsertBefore(T key, T value)
        {
            if (this.Head.Equals(null))
            {
                this.Head = new Node(value, null);
            }

            Node prev = null;
            Node curr = this.Head;
            while (curr != null && !curr.Value.Equals(key))
            {
                prev = curr;
                curr = curr.Next;
            }

            if (curr == null)
            {
                return this;
            }

            if (prev != null)
            {
                prev.Next = new Node(value, curr);
            }

            return this;
        }

        /// <summary>
        /// Inserts a value at the specified index.
        /// </summary>
        /// <param name="index">Index to insert at.</param>
        /// <param name="value">Value to insert.</param>
        /// <returns>The current instance of the class.</returns>
        public LinkedList<T> InsertAt(T index, T value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes a value.
        /// </summary>
        /// <param name="value">Value to remove.</param>
        /// <returns>The current instance of the class.</returns>
        public LinkedList<T> Remove(T value)
        {
            if (this.Head.Equals(null))
            {
                throw new ArgumentException("Head is null");
            }

            Node curr = this.Head;
            Node prev = null;
            while (curr != null && !curr.Value.Equals(value))
            {
                prev = curr;
                curr = curr.Next;
            }

            if (curr != null && curr.Equals(null))
            {
                throw new ArgumentException("Cannot delete");
            }

            if (prev == null)
            {
                return this;
            }

            if (curr != null)
            {
                prev.Next = curr.Next;
            }

            return this;
        }

        /// <summary>
        /// Removes all elements.
        /// </summary>
        /// <returns>The current instance of the class.</returns>
        public LinkedList<T> Clear()
        {
            if (this.Head.Equals(null))
            {
                return this;
            }

            Node curr = this.Head;
            while (curr != null && !curr.Value.Equals(null))
            {
                Node prev = curr;
                curr = curr.Next;
                prev.Next = null;
            }

            return this;
        }

        /// <summary>
        /// Class Node to keep track of each node in the list.
        /// </summary>
        private class Node
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="Node"/> class.
            /// </summary>
            /// <param name="value">Value to hold.</param>
            /// <param name="next">Next item in the list.</param>
            public Node(T value, Node next)
            {
                this.Value = value;
                this.Next = next;
            }

            /// <summary>
            /// Gets or sets the generic value of the item.
            /// </summary>
            /// <value>Value for the Node element.</value>
            public T Value { get; set; }

            /// <summary>
            /// Gets or sets the next Node in the list.
            /// </summary>
            /// <value>Sets the next node in the list.</value>
            public Node Next { get; set; }
        }
    }
}
