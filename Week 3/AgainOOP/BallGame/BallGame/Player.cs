namespace BallGame
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    class Player
    {
        private Vector position;
        private double speed;

        public Player(Vector pos, double sp)
        {
            this.Position = pos;
            this.Speed = sp;
        }
        public Vector Position
        {
            get { return this.position; }
            set { this.position = value; }
        }
        public double Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }
        public void MoveLeft()
        {
            this.position.X -= speed;
        }
        public LineSegment Shoot()
        {
            return new LineSegment(new Point(this.position.X,this.position.Y),new Point(this.position.X,))
        }
    }
}
