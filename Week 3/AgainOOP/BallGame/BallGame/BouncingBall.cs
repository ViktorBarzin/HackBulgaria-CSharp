using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BallGame
{
    class BouncingBall
    {
        private double diameter;
        private KeyValuePair<int, int> positionOfCenter;
        private double speed;
        private Color color;
        private KeyValuePair<int, int> direction;

        public BouncingBall()
        {

        }
        public double Diameter
        {
            get { return this.diameter; }
            set { this.diameter = value; }
        }
        public KeyValuePair<int, int> PositionOfCenter
        {
            get { return this.positionOfCenter; }
            set { this.positionOfCenter = value; }
        }
        public double Speec
        {
            get { return this.speed; }
            set { this.speed = value; }
        }
        public Color Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public KeyValuePair<int, int> Direction
        {
            get { return this.direction; }
            set { this.direction = value; }
        }

        public BouncingBall Move()
        {
            // move ?
            return this;
        }
    }
}
