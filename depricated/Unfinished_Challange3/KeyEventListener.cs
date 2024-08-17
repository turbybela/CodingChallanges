using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challenge3
{
    class KeyEventArgs : EventArgs
    {
        public ConsoleKey Key { get; set; }
    }
    internal class KeyEventListener
    {
        public event EventHandler<KeyEventArgs> KeyEvent;

        public KeyEventListener()
        {
            Task.Run(() => { Listener(); });
        }

        private void Listener()
        {
            while (true)
            {
                try
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    KeyEvent?.Invoke(this, new KeyEventArgs() { Key = keyInfo.Key });
                    Thread.Sleep(10);
                }
                catch { }
            }
        }
    }
}
