namespace FastAndFurious
{
    /// <summary>
    /// Class Honda.
    /// </summary>
    public class Honda : Car
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
