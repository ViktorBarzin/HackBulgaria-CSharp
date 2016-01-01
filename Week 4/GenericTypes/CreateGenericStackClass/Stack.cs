namespace CreateGenericStackClass
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Generic Class Stack.
    /// </summary>
    /// <typeparam name="T">Generic type supported.</typeparam>
    public class Stack<T>
    {
        /// <summary>
        /// List of generic items.
        /// </summary>
        private List<T> items = new List<T>();

        /// <summary>
        /// Displays the last added element without removing it.
        /// </summary>
        public void Peek()
        {
            try
            {
                Console.WriteLine(this.items[this.items.Count - 1]);
            }
            catch (ArgumentOutOfRangeException exp)
            {
                Console.WriteLine(exp.Message);
                Console.WriteLine("Stack empty");
            }
        }

        /// <summary>
        /// Removes the last added element.
        /// </summary>
        /// <returns>The last added element.</returns>
        public T Pop()
        {
            T pop = this.items[this.items.Count - 1];
            this.items.Remove(pop);
            return pop;
        }

        /// <summary>
        /// Adds a new element.
        /// </summary>
        /// <param name="item">Element to add.</param>
        /// <returns>The current instance for chaining.</returns>
        public Stack<T> Push(T item)
        {
            this.items.Add(item);
            return this;
        }

        /// <summary>
        /// Removes all elements.
        /// </summary>
        /// <returns>The current instance of the class.</returns>
        public Stack<T> Clear()
        {
            this.items = new List<T>();
            return this;
        }

        /// <summary>
        /// Checks if the object contains a generic input item.
        /// </summary>
        /// <param name="item">Item to check.</param>
        /// <returns>True if items exists.</returns>
        public bool Contains(T item)
        {
            foreach (T toFind in this.items)
            {
                if (toFind.ToString() == item.ToString())
                {
                    return true;
                }
            }

            return false;
        }
    }
}
