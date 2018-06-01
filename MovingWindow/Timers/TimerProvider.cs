using System.Windows.Forms;

namespace MovingWindow.Timers
{
    internal sealed class TimerProvider : ITimerProvider
    {
        private readonly Timer timer = new Timer();

        public TimerProvider()
        {
            timer.Enabled = false;
            timer.Interval = 100;
        }

        public Timer Timer => timer;
    }
}