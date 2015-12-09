namespace BallGame
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    public class BouncingBall
    {
        private double diameter;
        public double speed;
        private Color color;
        public Vector positionOfCenter;
        public Vector direction = new Vector();

        public BouncingBall(double d,double sp,Color col, Vector positionOfOrigin,Vector dir)
        {
            this.Diameter = d;
            this.Speed = sp;
            this.Color = col;
            this.PositionOfCenter = positionOfOrigin;
            this.Direction = dir;
        }
        public double Diameter
        {
            get { return this.diameter; }
            set { this.diameter = value; }
        }
        public Vector PositionOfCenter
        {
            get { return this.positionOfCenter; }
            set { this.positionOfCenter = value; }
        }
        public double Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }
        public Color Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public Vector Direction
        {
            get { return this.direction; }
            set { this.direction = value; }
        }
        public BouncingBall Move(BouncingBall ball)
        {
            ball.positionOfCenter += ball.direction * ball.speed;
            return ball;
        }
    }
}
