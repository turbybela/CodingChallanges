using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challenge2
{
    public class KeyEventArgs : EventArgs
    {
        public ConsoleKey Key;
    }
    public class KeyEventListener
    {
        public event EventHandler<KeyEventArgs> KeyEventHandler;
        Task task;
        public KeyEventListener()
        {
            Console.CursorVisible = false;
            task = Task.Run(() => ReadConsoleInput());
        }
        private void ReadConsoleInput()
        {
            while (true)
            {
                try
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    KeyEventHandler?.Invoke(this, new KeyEventArgs { Key = key.Key });
                    Thread.Sleep(10);
                }
                catch { }
            }
        }
    }
}
