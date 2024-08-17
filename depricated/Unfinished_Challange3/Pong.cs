using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    struct Score
    {
        public int Player1 { get; set; }
        public int Player2 { get; set; }
    }
    class Point<T>
    {
        public T x { get; set; }
        public T y { get; set; }

        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point<T> operator +(Point<T> p1, Point<T> p2)
        {
            return new Point<T>((dynamic)p1.x + p2.x, (dynamic)p1.y + p2.y);
        }
    }

    internal class Pong
    {


        public Point<float> BallPosition { get; private set; }
        public Point<int> OnScreenPosition { get { return new Point<int>((int)(BallPosition.x + 0.5), (int)(BallPosition.y + 0.5)); } } // round BallPosition
        public Point<float> BallVelocity { get; private set; }


        public void AdvanceBall(int WindowWidth, int WindowHeight)
        {
            BallPosition += BallVelocity;

            if ()
        }

    }

    class Paddle
    {
        private bool _paddleMoved = false;
        public bool PaddleMoved { get { bool p = _paddleMoved; _paddleMoved = false; return p; } }

        private const int paddleSpeed = 1;
        private readonly int xPos;
        private int yPos;
        private int height;

        public Paddle(int xPos, int yPos, int height)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.height = height;
        }
        private bool Collision(Point<int> point)
        {
            if (point.x != xPos) return false; // Not in same column
            
            if (point.y < yPos) return false; // Above

            if (point.y > yPos+height) return false; // Below

            return true;
        }

        public void MovePaddle(bool down_dir, int window_height)
        {
            int p = yPos;
            if (down_dir) yPos += paddleSpeed;
            else yPos -= paddleSpeed;

            if (yPos < 0) yPos = 0;
            if (yPos + height > window_height) yPos = window_height - height;

            if (yPos != p) _paddleMoved = true;
        }

        public void MovePaddleTo(int position, int window_height)
        {
            int p = yPos;

            yPos = position - height / 2;

            if (yPos < 0) yPos = 0;
            if (yPos + height > window_height) yPos = window_height - height;

            if (yPos != p) _paddleMoved = true;
        }

        public void ErasePaddle(int window_height)
        {
            string Destroyer = string.Join("\n", new string(' ', xPos).ToCharArray());

            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < window_height; ++i)
                Console.Write(Destroyer);
        }
        public void DisplayPaddle()
        {
            const string visual = " ";

            Console.BackgroundColor = ConsoleColor.White;

            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(xPos, yPos+i);
                Console.Write(visual);
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
