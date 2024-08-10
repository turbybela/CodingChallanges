/*
 * Go to Challenge.cs and solve all the challenges before you check this file. You can run at any time. Only check after all the challenges has been completed.
 * 
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS
    GOTO CHALLANGE.CS































        NO.
*/using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    struct Point
    {
        public static Point Zero { get { return new Point(0, 0); } }
        public static Point Up { get { return new Point(0, -1); } }
        public static Point Down { get { return new Point(0, 1); } }
        public static Point Left { get { return new Point(-1, 0); } }
        public static Point Right { get { return new Point(1, 0); } }
        public static readonly Point[] Directions = new Point[] {Up, Down, Left, Right };

        public int x;
        public int y;
        public Point(int x, int y) 
        { 
            this.x = x; 
            this.y = y; 
        }

        public static Point operator +(Point left, Point right)
        {
            return new Point(left.x + right.x, left.y + right.y);
        }
        public static Point operator -(Point left, Point right)
        {
            return new Point(left.x - right.x, left.y - right.y);
        }
        public override bool Equals(object obj)
        {
            return obj is Point point &&
                   x == point.x &&
                   y == point.y;
        }

        public override int GetHashCode()
        {
            int hashCode = 1502939027;
            hashCode = hashCode * -1521134295 + x.GetHashCode();
            hashCode = hashCode * -1521134295 + y.GetHashCode();
            return hashCode;
        }
        // override object.Equals

    }
    class Snake
    {
        public Point Head { get; private set; }
        public Point Facing { get; private set; }
        private List<Point> _tail = new List<Point>();
        public List<Point> Tail { get { return _tail; } private set { _tail = value; } }

        private bool Increased;

        public Snake()
        {
            Head = new Point();
            Facing = Point.Right;
            Tail = new List<Point>();
            Increased = false;

        }

        public bool Move(int width, int height)
        {
            if (width <= 5 || height < 5) throw new Exception("Play Area Too Small");


            if (Tail.Count() > 0)
            {
                Point last = Challenge.Challenge3(ref _tail, Head);

                if (Increased)
                    Tail.Add(last);
            }
            else if (Increased)
            {
                Tail.Add(Head);
            }
            Increased = false;

            Head += Facing;

            Head = Challenge.Challenge4(Head, width, height);

            return !Tail.Contains(Head); // If head and tail collided (same coordinates) we lost, and return false.
        }

        public void Rotate(Point? _direction)
        {
            if (_direction == null) return;
            Point direction = (Point)_direction;

            if (Point.Zero.Equals(Facing + direction)) return; 

            if (Point.Directions.Contains(direction))
                Facing = direction;
            else
                throw new Exception("Invalid direction!");
        }

        public void Increase()
        {
            Increased = true;
        }

        public bool Collider(Point point)
        {
            if (Head.Equals(point)) return true;
            if (Tail.Contains(point)) return true;
            return false;
        }
    }

    class Apple
    {
        public Point Position { get; private set; }
        Random r = new Random();
        public Apple(int width, int height)
        {
            if (width <= 5 || height < 5) throw new Exception("Play Area Too Small");
            Position = Challenge.Challenge2(width, height);
        }

        public void NewApple(int width, int height)
        {
            if (width <= 5 || height < 5) throw new Exception("Play Area Too Small");
            Position = Challenge.Challenge2(width, height);
        }
    }
}
