using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    internal abstract class BaseGameState
    {
        public abstract void Update(float deltaTime);
        public abstract void Reset();
    }
}
