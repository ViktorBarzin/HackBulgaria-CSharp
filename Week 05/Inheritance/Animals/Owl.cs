namespace Animals
{
    /// <summary>
    /// Class Owl.
    /// </summary>
    public class Owl : Bird
    {
        /// <summary>
        /// Overrides Greet() method.
        /// </summary>
        /// <returns>String greet from Owl.</returns>
        public override string Greet()
        {
            return string.Format("Buu-buu");
        }
    }
}
