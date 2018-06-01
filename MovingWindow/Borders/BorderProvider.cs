using System.Windows.Forms;

namespace MovingWindow.Borders
{
    internal sealed class BorderProvider : IBorderProvider
    {
        public int Bottom => Screen.PrimaryScreen.Bounds.Height;
        public int Left => 0;
        public int Right => Screen.PrimaryScreen.Bounds.Width;
        public int Top => 0;
    }
}