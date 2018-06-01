namespace MovingWindow.Movements
{
    internal sealed class DirectionManager : IDirectionProvider, IDirectionManager
    {
        public Direction Direction { get; set; } = Directions.None;
    }
}