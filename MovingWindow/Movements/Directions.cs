namespace MovingWindow.Movements
{
    internal static class Directions
    {
        public static Direction Down => new Direction(0, 1);
       
        public static Direction Left => new Direction(-1, 0);

        public static Direction None => new Direction(0, 0);

        public static Direction Right => new Direction(1, 0);

        public static Direction Up => new Direction(0, -1);
    }
}