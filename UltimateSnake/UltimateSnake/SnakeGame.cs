namespace UltimateSnake
{
    using UltimateSnake.Utilities;

    public abstract class SnakeGame
    {
        /// <summary>
        /// Gets or sets the size of the window (remember that the console uses rows and columns, NOT pixels)
        /// </summary>
        public static Point WindowSize { get; protected set; }

        /// <summary>
        /// Gets or sets the mid-point of the screen
        /// </summary>
        public static Point MidScreen { get; protected set; }

        /// <summary>
        /// Gets or sets the mid-point of the screen
        /// </summary>
        public static int FPS { get; set; }


    }
}
