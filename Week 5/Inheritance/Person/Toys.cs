namespace Person
{
    using System.Drawing;

    /// <summary>
    /// Class Toy.
    /// </summary>
    public class Toy
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Toy"/> class.
        /// </summary>
        /// <param name="color">Color of the Toy.</param>
        /// <param name="size">Size of the Toy.</param>
        public Toy(Color color, int size)
        {
            this.Color = color;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Toy"/> class.
        /// </summary>
        public Toy()
        {
        }

        /// <summary>
        /// Gets Color property. 
        /// </summary>
        /// <value>Setter in constructor.</value>
        public Color Color { get; }

        /// <summary>
        /// Gets Size property.
        /// </summary>
        /// <value>Setter in constructor.</value>
        public int Size { get; }

        /// <summary>
        /// Overrides ToString() method for Toy class.
        /// </summary>
        /// <returns>Toy object as String.</returns>
        public override string ToString()
        {
            return string.Format("{0} color, {1} big", this.Color, this.Size);
        }
    }
}
