namespace Animals
{
    /// <summary>
    /// Class Dog.
    /// </summary>
    public class Dog : Mammals
    {
        /// <summary>
        /// Greet method for dog.
        /// </summary>
        /// <returns>String Greet.</returns>
        public override string Greet()
        {
            return string.Format("Balo balo");
        }
    }
}
