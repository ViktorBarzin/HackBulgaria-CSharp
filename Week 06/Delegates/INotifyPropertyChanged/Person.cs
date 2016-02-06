namespace INotifyPropertyChanged
{
    using System.ComponentModel;

    /// <summary>
    /// Person class
    /// </summary>
    public class Person : INotifyPropertyChanged
    {
        /// <summary>
        /// Person name.
        /// </summary>
        private string name = string.Empty;

        /// <summary>
        /// Person age.
        /// </summary>
        private int age;

        /// <summary>
        /// Event handler for property changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets person name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (this.PropertyChanged != null && this.name != null && value != this.name)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }

                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets person age.
        /// </summary>
        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (this.PropertyChanged != null && value != this.age)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Age"));
                }

                this.age = value;
            }
        }

        /// <summary>
        /// Overrides GetHashCode() for person class.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode()
        {
            return (this.name.GetHashCode() * 23) + (this.age.GetHashCode() * 17);
        }
    }
}
