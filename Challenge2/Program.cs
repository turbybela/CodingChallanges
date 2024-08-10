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
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Program
    {

        static bool Passed = true;

        static void TEST(int index, KeyValuePair<string, bool>[] pass_conditions)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Challenge " +  index + ": ");

            foreach (var pc in pass_conditions)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\t" + pc.Key + ": ");
                if (pc.Value)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PASSED");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("FAILED");
                    Passed = false;
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }


        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;

            TEST(1, new KeyValuePair<string, bool>[] {
                new KeyValuePair<string, bool>(
                    "UNKNOWN_KEY",
                    Challenge.Challenge1(ConsoleKey.Escape) is null),
                new KeyValuePair<string, bool>(
                    "KNOWN_KEY",
                    !(Challenge.Challenge1(ConsoleKey.W) is null)),
                new KeyValuePair<string, bool>(
                    "ARROWUP_TEST",
                    Challenge.Challenge1(ConsoleKey.UpArrow).Equals(Point.Up)),
                new KeyValuePair<string, bool>(
                    "ARROWLEFT_TEST",
                    Challenge.Challenge1(ConsoleKey.LeftArrow).Equals(Point.Left)),
                new KeyValuePair<string, bool>(
                    "ARROWDOWN_TEST",
                    Challenge.Challenge1(ConsoleKey.DownArrow).Equals(Point.Down)),
                new KeyValuePair<string, bool>(
                    "ARROWRIGHT_TEST",
                    Challenge.Challenge1(ConsoleKey.RightArrow).Equals(Point.Right)),
                new KeyValuePair<string, bool>(
                    "LETTERW_TEST",
                    Challenge.Challenge1(ConsoleKey.W).Equals(Point.Up)),
                new KeyValuePair<string, bool>(
                    "LETTERA_TEST",
                    Challenge.Challenge1(ConsoleKey.A).Equals(Point.Left)),
                new KeyValuePair<string, bool>(
                    "LETTERS_TEST",
                    Challenge.Challenge1(ConsoleKey.S).Equals(Point.Down)),
                new KeyValuePair<string, bool>(
                    "LETTERD_TEST",
                    Challenge.Challenge1(ConsoleKey.D).Equals(Point.Right))
                });

            Point T2_p = Challenge.Challenge2(100, 100);
            TEST(2, new KeyValuePair<string, bool>[] {
                new KeyValuePair<string, bool>(
                    "IN_BOUNDS_X",
                     T2_p.x < 100 && T2_p.x >= 0 ),
                new KeyValuePair<string, bool>(
                    "IN_BOUNDS_Y",
                     T2_p.y < 100 && T2_p.y >= 0 ),
            });

            List<Point> nullArr = null;
            List<Point> emptyArr = new List<Point>();
            List<Point> pts = new List<Point>() { new Point(10,10), new Point(20, 20), new Point(30, 30) };
            List<Point> pts_after = new List<Point>() { new Point(0, 0), new Point(10, 10), new Point(20, 20) };
            TEST(3, new KeyValuePair<string, bool>[]{
                new KeyValuePair<string, bool>(
                    "NULL_ARRAY",
                    Challenge.Challenge3(ref nullArr, new Point(10, 10)).Equals(new Point(10,10))),
                new KeyValuePair<string, bool>(
                    "NULL_ARRAY_STILL_NULL",
                    nullArr is null),
                new KeyValuePair<string, bool>(
                    "EMPTY_ARRAY",
                    Challenge.Challenge3(ref emptyArr, new Point(100, 100)).Equals(new Point(100,100))),
                new KeyValuePair<string, bool>(
                    "EMPTY_ARRAY_STILL_EMPTY",
                    emptyArr.Count == 0),
                new KeyValuePair<string, bool>(
                    "SHIFTING_LAST",
                    Challenge.Challenge3(ref pts, new Point(0,0)).Equals(new Point(30,30))),
                new KeyValuePair<string, bool>(
                    "SHIFTING_ARRAY",
                    pts_after.SequenceEqual(pts))
            });

            TEST(4, new KeyValuePair<string, bool>[]{
                new KeyValuePair<string, bool>(
                    "CORRECT_POINT",
                    Challenge.Challenge4(new Point(), 1, 1).Equals(new Point())),
                new KeyValuePair<string, bool>(
                    "CORRECT_POINT2",
                    Challenge.Challenge4(new Point(999,999), 1000, 1000).Equals(new Point(999,999))),
                new KeyValuePair<string, bool>(
                    "OUTSIDE_POSITIVE",
                    Challenge.Challenge4(new Point(15,15), 10, 10).Equals(new Point(5,5))),
                new KeyValuePair<string, bool>(
                    "OUTSIDE_NEGATIVE",
                    Challenge.Challenge4(new Point(-5,-5), 10, 10).Equals(new Point(5,5))),
                new KeyValuePair<string, bool>(
                    "OUTSIDE_FAR_POSITIVE",
                    Challenge.Challenge4(new Point(999,999), 10, 10).Equals(new Point(9,9))),
                new KeyValuePair<string, bool>(
                    "OUTSIDE_FAR_NEGATIVE",
                    Challenge.Challenge4(new Point(-999,-999), 10, 10).Equals(new Point(1,1))),
            });


            Console.WriteLine("Press any key to " + (Passed ? "continue" : "exit") + "...");
            Console.ReadKey();
            if (!Passed) return;
            Console.Clear();

            /*
             Final program below.


















































































             */

            KeyEventListener keyListener = new KeyEventListener();
            keyListener.KeyEventHandler += OnKeyEvent;

            Apple apple = new Apple(Console.WindowWidth, Console.WindowHeight);
            snake = new Snake();

            while (true)
            {
                if (snake.Collider(apple.Position))
                {
                    snake.Increase();
                    apple.NewApple(Console.WindowWidth, Console.WindowHeight);
                }

                Console.SetCursorPosition(apple.Position.x, apple.Position.y);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(' ');

                Console.SetCursorPosition(snake.Head.x, snake.Head.y);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write(' ');

                Console.BackgroundColor = ConsoleColor.Green;
                foreach (var pos in snake.Tail)
                {
                    Console.SetCursorPosition(pos.x, pos.y);
                    Console.Write(' ');
                }

                Thread.Sleep(150);

                if (!snake.Move(Console.WindowWidth, Console.WindowHeight)) break;

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
            }

            string text = "You lost!";
            Console.SetCursorPosition(Console.WindowWidth / 2 - text.Length / 2, Console.WindowHeight/2);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(text);
            Console.ReadKey(true);
        }

        static Snake snake; // hidden from u. would be at top.
        static void OnKeyEvent(object sender, KeyEventArgs e)
        {
            if (snake == null) return;
            snake.Rotate(Challenge.Challenge1(e.Key)); // Dismissing 
            if (e.Key == ConsoleKey.F5) snake.Increase();
        }
    }
}
