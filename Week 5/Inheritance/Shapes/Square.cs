namespace Shapes
{
    public class Square : Rectangle
    {
        public Square(double side) : base(side, side)
        {
            this.Height = this.Side;
            this.Width = this.Side;
            this.Side = side;
        }

        protected double Side { get; set; }
    }
}
