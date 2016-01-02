namespace FastAndFurious
{
    /// <summary>
    /// Abstract class GermanCars. 
    /// </summary>
    public abstract class GermanCars : Car
    {
        /// <summary>
        /// Mileage field.
        /// </summary>
        private int mileage;

        /// <summary>
        /// Initializes a new instance of the <see cref="GermanCars"/> class.
        /// </summary>
        /// <param name="mileage">Set the mileage property.</param>
        protected GermanCars(int mileage)
        {
            this.mileage = mileage;
        }

        /// <summary>
        /// Overrides the IsEcoFriendly() method.
        /// </summary>
        /// <param name="testing">Testing input variable.</param>
        /// <returns>Testing variable.</returns>
        public override bool IsEcoFriendly(bool testing)
        {
            return true;
        }
    }
}
