using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateSnake
{
    using UltimateSnake.Utilities;

    public sealed class ConsoleSnakeGame : SnakeGame
    {
        private ConsoleSnakeGame()
        {
            this.WindowSize = new Point(Console.WindowWidth, Console.WindowHeight);
            this.MidScreen = new Point(this.WindowSize.X / 2, this.WindowSize.Y / 2);
            this.FPS = 10;
        }

        public override Point WindowSize { get; protected set; }

        public override Point MidScreen { get; protected set; }

        public static void GameLoop()
        {
            ConsoleSnakeGame snake = new ConsoleSnakeGame();
        }
    }
}
