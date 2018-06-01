namespace MovingWindow.Borders
{
    internal interface IBorderProvider
    {
        int Bottom { get; }
        int Left {get;}
        int Right { get; }
        int Top { get; }
    }
}