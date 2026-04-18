using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    internal class ConsoleInput
    {
        private List<IArrowListener> arrowListeners = new();

        public void Subscribe(IArrowListener listener)
        {
            arrowListeners.Add(listener);
        }

        public void Update()
        {
            if (!Console.KeyAvailable)
                return;

            var key = Console.ReadKey();
            foreach (var a in arrowListeners)
            {
                switch (key.Key)
                {
                    case ConsoleKey.W: a.OnArrowUp(); break;
                    case ConsoleKey.A: a.OnArrowLeft(); break;
                    case ConsoleKey.S: a.OnArrowDown(); break;
                    case ConsoleKey.D: a.OnArrowRight(); break;
                }    
            }
        }
    }
}
