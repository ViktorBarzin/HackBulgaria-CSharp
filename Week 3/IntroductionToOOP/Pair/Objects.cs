namespace Pair
{
    public class Objects
    {
        public Objects(object key, object value)
        {
            this.Key = key;
            this.Value = value;
        }

        public object Key { get; }

        public object Value { get; }

        public override string ToString()
        {
            return string.Format(this.Key + ":" + this.Value);
        }

        public override bool Equals(object obj)
        {
            if (this.Value == (obj as Objects).Value && this.Key == (obj as Objects).Key)
            {
                return true;
            }

            return false;
        }

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
