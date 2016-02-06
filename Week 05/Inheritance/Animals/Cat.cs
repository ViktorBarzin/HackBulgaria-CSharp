namespace Animals
{
    /// <summary>
    /// Class Cat.
    /// </summary>
    public class Cat : Mammals
    {
        /// <summary>
        /// Greet method for Cat class.
        /// </summary>
        /// <returns>String greet from Cat.</returns>
        public override string Greet()
        {
            return string.Format("Meow");
        }
    }
}
