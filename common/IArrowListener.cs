using System;
using System.Collections.Generic;
using System.Text;

namespace snake.common
{
    internal interface IArrowListener
    {
        public abstract void OnArrowUp();
        public abstract void OnArrowDown();
        public abstract void OnArrowLeft();
        public abstract void OnArrowRight();

    }
}
