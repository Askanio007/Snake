using snake.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace snake.core
{
    class SnakeGameplayState : BaseGameState
    {
        private List<Cell> _body = new();
        private Direction _currentDir;
        private float _timeToMove;
        private float timeStep = 2;

        public override void Reset()
        {
            _body = new();
            _currentDir = Direction.Right;
            _body.Add(new Cell(0, 0));
            _timeToMove = 0;
        }

        public override void Update(float deltaTime)
        {
            _timeToMove = _timeToMove - deltaTime;
            if (_timeToMove > 0)
            {
                return;
            }
            _timeToMove = 1 / timeStep;

            var head = _body[0];
            var newCell =ShiftTo(head);
            _body.RemoveAt(_body.Count - 1);
            _body.Insert(0, newCell);
            var newHead = _body[0];
            Console.WriteLine($"New head X={newHead.X} Y={newHead.Y} dir={_currentDir}");
        }

        public void SetDirection(Direction dir)
        {
            this._currentDir = dir;
        }

        private Cell ShiftTo(Cell current)
        {
            switch (_currentDir)
            {
                case Direction.Left: return new Cell(current.X + 1, current.Y);
                case Direction.Right: return new Cell(current.X - 1, current.Y);
                case Direction.Up: return new Cell(current.X, current.Y + 1);
                case Direction.Down: return new Cell(current.X, current.Y - 1);
                default: throw new InvalidDataException($"Invlide direction {_currentDir}");
            }
        }
    }

    public struct Cell 
    {
        public int X { get; }
        public int Y { get; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

}
