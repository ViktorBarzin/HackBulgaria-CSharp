namespace NotifyCollection
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>
    /// Notify collection change.
    /// </summary>
    /// <typeparam name="T">Type of the elements.</typeparam>
    public class NotifyCollection<T>
        where T : INotifyPropertyChanged
    {
        /// <summary>
        /// List of items.
        /// </summary>
        private IList<T> items = new List<T>();

        /// <summary>
        /// Event listening if the collection changes.
        /// </summary>
        public event PropertyChangedEventHandler CollectionChanged;

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        public IList<T> Items
        {
            get
            {
                return this.items;
            }

            set
            {
                if (this.CollectionChanged != null && this.items != value)
                {
                    this.CollectionChanged(this, new PropertyChangedEventArgs("Changed items"));
                }

                this.items = value;
            }
        }

        /// <summary>
        /// Adds a new item.
        /// </summary>
        /// <param name="item">Item to add.</param>
        public void AddNumber(T item)
        {
            this.items.Add(item);
            item.PropertyChanged += this.CollectionChanged;
            if (this.CollectionChanged != null)
            {
                this.CollectionChanged(this, new PropertyChangedEventArgs(string.Format("Added a number {0} at index {1}", item, this.items.Count)));
            }
        }

        /// <summary>
        /// Removes an item from the items list.
        /// </summary>
        /// <param name="item">Item to remove.</param>
        public void Remove(T item)
        {
            item.PropertyChanged -= this.CollectionChanged;

            if (!this.items.Contains(item))
            {
                throw new ArgumentException(string.Format("{0} is not present in the collection", item));
            }

            if (this.CollectionChanged != null)
            {
                this.CollectionChanged(this, new PropertyChangedEventArgs(string.Format("Removed element {0} at index {1}", item.ToString(), this.items.IndexOf(item))));
            }

            this.items.Remove(item);
        }

        /// <summary>
        /// Replaces an item in the list with another one.
        /// </summary>
        /// <param name="itemToReplace">Item to replace.</param>
        /// <param name="replacement">Item to replace with.</param>
        public void Replace(T itemToReplace, T replacement)
        {
            if (!this.items.Contains(itemToReplace))
            {
                throw new ArgumentException(string.Format("Collection does not contain {0}", itemToReplace));
            }

            if (this.CollectionChanged != null && this.items.Contains(itemToReplace))
            {
                this.CollectionChanged(this, new PropertyChangedEventArgs(string.Format("Replace item {0} with {1}", itemToReplace, replacement)));
            }

            int index = this.items.IndexOf(itemToReplace);
            this.items.Remove(itemToReplace);
            this.items.Insert(index, replacement);
        }
    }
}
