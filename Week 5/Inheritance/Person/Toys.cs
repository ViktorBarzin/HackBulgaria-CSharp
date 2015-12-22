namespace Person
{
    using System.Drawing;

    public class Toy
    {
        public Toy(Color color, int size)
        {
            this.Color1 = color;
            this.Size1 = size;
        }

        public Toy()
        {
        }

        public Color Color1 { get; }

        public int Size1 { get; }

        public override string ToString()
        {
            return string.Format("{0} color, {1} big", this.Color1, this.Size1);
        }
    }
}
