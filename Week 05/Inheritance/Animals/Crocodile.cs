namespace Animals
{
    /// <summary>
    /// Class Crocodile.
    /// </summary>
    public class Crocodile : Animals, ILandAnimals
    {
        /// <summary>
        /// Overrides Greet() method.
        /// </summary>
        /// <returns>String greet from Crocodile.</returns>
        public override string Greet()
        {
            return string.Format("krok krok");
        }
    }
}
