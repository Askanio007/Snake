using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class SnakeGameLogic : BaseGameLogic
    {
        SnakeGameplayState gameplayState;

        public SnakeGameLogic(ConsoleInput input)
        {
            this.gameplayState = new SnakeGameplayState();
            InitializeInput(input);
        }

        public override void Update(float deltaTime)
        {
            gameplayState.Update(deltaTime);
        }

        public void GotoGameplay()
        {
            gameplayState.Reset();
        }

        public override void OnArrowDown()
        {
            gameplayState.SetDirection(Direction.Down);
        }

        public override void OnArrowLeft()
        {
            gameplayState.SetDirection(Direction.Left);
        }

        public override void OnArrowRight()
        {
            gameplayState.SetDirection(Direction.Right);
        }

        public override void OnArrowUp()
        {
            gameplayState.SetDirection(Direction.Up);
        }
    }
}
