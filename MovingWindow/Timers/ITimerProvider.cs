using System.Windows.Forms;

namespace MovingWindow.Timers
{
    internal interface ITimerProvider
    {
        Timer Timer { get; }
    }
}