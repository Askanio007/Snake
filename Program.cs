
using snake.core;
using snake.input;

namespace snake
{
    internal class SnakeGame
    {
        public static void Main(string[] args)
        {
            var input = new ConsoleInput();
            var gameLogic = new SnakeGameLogic(input);
            var lastFrameTime = DateTime.Now;
            gameLogic.GotoGameplay();

            while (true)
            {
                input.Update();
                var frameStartTime = DateTime.Now;
                float deltaTime = (float)(frameStartTime - lastFrameTime).TotalSeconds;
                gameLogic.Update(deltaTime);
                lastFrameTime = frameStartTime;
            }
        }
    }
}
