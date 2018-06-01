namespace MovingWindow.Movements
{
    internal sealed class Direction
    {
        public Direction(int offsetX, int offsetY)
        {
            OffsetX = offsetX;
            OffsetY = offsetY;
        }

        public int OffsetX { get; }

        public int OffsetY { get; }
    }
}