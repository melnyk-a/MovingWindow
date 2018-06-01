using MovingWindow.Timers;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovingWindow.Commands.TimerCommands
{
    internal abstract class TimerCommand : Command
    {
        protected readonly ITimerProvider timerProvider;

        public TimerCommand(ITimerProvider timerProvider, IEnumerable<Keys> keys) :
            base(keys)
        {
            this.timerProvider = timerProvider;
        }
    }
}