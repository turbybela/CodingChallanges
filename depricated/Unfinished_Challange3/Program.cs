using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Program
    {
        static Paddle paddle;

        static void onKeyEvent(object sender, KeyEventArgs e)
        {
            if (e.Key == ConsoleKey.W) paddle.MovePaddle(false, Console.WindowHeight);
            else if (e.Key == ConsoleKey.S) paddle.MovePaddle(true, Console.WindowHeight);
        }

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            KeyEventListener keyEventListener = new KeyEventListener();
            keyEventListener.KeyEvent += onKeyEvent;

            paddle = new Paddle(3, 0, 10);

            while (true)
            {
                paddle.DisplayPaddle();

                Thread.Sleep(10);
                if (paddle.PaddleMoved)Console.Clear();

            }


        }

        private static void KeyEventListener_KeyEvent(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
