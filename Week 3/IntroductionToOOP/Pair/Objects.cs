namespace Pair
{
    /// <summary>
    /// Class Objects.
    /// </summary>
    public class Objects
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Objects"/> class.
        /// </summary>
        /// <param name="key">Sets key as key property.</param>
        /// <param name="value">Sets value as value property.</param>
        public Objects(object key, object value)
        {
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Gets the key property.
        /// </summary>
        /// <value>Private setter.</value>
        public object Key { get; }

        /// <summary>
        /// Gets the value property.
        /// </summary>
        /// <value>Private setter.</value>
        public object Value { get; }

        /// <summary>
        /// Overrides ToString() method of the Objects class.
        /// </summary>
        /// <returns>Returns current instance of Objects as String.</returns>
        public override string ToString()
        {
            return string.Format(this.Key + ":" + this.Value);
        }

        /// <summary>
        /// Overrides Equals() method for Objects class.
        /// </summary>
        /// <param name="obj">Object to compare.</param>
        /// <returns>True if object equals current instance of Objects class.</returns>
        public override bool Equals(object obj)
        {
            if (this.Value == (obj as Objects).Value && this.Key == (obj as Objects).Key)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Overrides GetHashCode() for Objects class.
        /// </summary>
        /// <returns>HashCode for current instance of Objects class.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = (hash * 23) + this.Key.GetHashCode();
                hash = (hash * 23) + this.Value.GetHashCode();
                return hash;
            }
        }
    }
}
