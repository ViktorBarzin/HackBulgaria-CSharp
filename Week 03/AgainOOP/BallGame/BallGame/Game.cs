namespace BallGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    
    public class Game
    {
        private List<BouncingBall> listOfBalls = new List<BouncingBall>();
        private int width;
        private int height;
        private Rectangle gameRectangle;
        public Game(int w,int h)
        {
            this.gameRectangle = new Rectangle(new Point(0, 0), new Point(w, h));
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

        public void MoveAll(ref List<BouncingBall> listOfBalls)
        {
            foreach (BouncingBall ball in listOfBalls)
            {
                if (this.gameRectangle.IsInsideOfRect(new Point(ball.positionOfCenter.X + ball.direction.X,ball.positionOfCenter.Y + ball.direction.Y)))
                {
                    ball.Move(ball);
                }
                else if (this.gameRectangle.IsInsideOfRect(new Point(ball.positionOfCenter.X - ball.direction.X, ball.positionOfCenter.Y + ball.direction.Y)))
                {

                }
                else if (this.gameRectangle.IsInsideOfRect(new Point(ball.positionOfCenter.X - ball.direction.X, ball.positionOfCenter.Y - ball.direction.Y)))
                {

                }
                else if(this.gameRectangle.IsInsideOfRect(new Point(ball.positionOfCenter.X + ball.direction.X, ball.positionOfCenter.Y - ball.direction.Y)))
                {

                }
            }
        }
    }
}
