namespace FastAndFurious
{
    /// <summary>
    /// Class Skoda.
    /// </summary>
    public class Skoda : Car
    {
        /// <summary>
        /// Overrides the IsEcoFriendly() method.
        /// </summary>
        /// <param name="testing">Testing variable input.</param>
        /// <returns>Testing variable.</returns>
        public override bool IsEcoFriendly(bool testing)
        {
            return true;
        }
    }
}
