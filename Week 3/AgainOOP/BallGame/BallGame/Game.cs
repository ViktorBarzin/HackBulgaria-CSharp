using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGame
{
    class Game
    {
        private List<BouncingBall> listOfBalls = new List<BouncingBall>();
        private int width;
        private int height;
        public Game(int w,int h)
        {
            this.Width = w;
            this.Height = h;
        }
        public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public List<BouncingBall> ListOfBalls
        {
            get { return this.listOfBalls; }
            set { this.listOfBalls = value; }
        }
    }
}
