using MovingWindow.Timers;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovingWindow.Commands.TimerCommands
{
    internal sealed class StartTimerCommand : TimerCommand
    {
        public StartTimerCommand(ITimerProvider timerProvider, IEnumerable<Keys> keys) :
            base(timerProvider, keys)
        {
        }

        public override void Execute()
        {
            if (!timerProvider.Timer.Enabled)
            {
                timerProvider.Timer.Start();
            }
        }
    }
}