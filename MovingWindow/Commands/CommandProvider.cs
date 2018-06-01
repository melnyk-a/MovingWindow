using MovingWindow.Commands.DirectionCommands;
using MovingWindow.Commands.TimerCommands;
using MovingWindow.Movements;
using MovingWindow.Timers;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovingWindow.Commands
{
    internal sealed class CommandProvider : ICommandProvider
    {
        private IEnumerable<Command> commands;

        public CommandProvider(IDirectionManager directionManager, ITimerProvider timerProvider, Form form)
        {
            commands = new List<Command> {
                new StartTimerCommand(timerProvider, new[]{Keys.Left, Keys.Right, Keys.Up, Keys.Down }),
                new StopTimerCommand(timerProvider, new[]{Keys.Return}),
                new LeftDirectionCommand(directionManager, new[]{Keys.Left }),
                new RightDirectionCommand(directionManager, new[]{Keys.Right }),
                new UpDirectionCommand(directionManager, new[]{Keys.Up }),
                new DownDirectionCommand(directionManager, new[]{Keys.Down }),
                new NoneDirectionCommand(directionManager, new[]{Keys.Return }),
                new CenterCommand(form, new[]{Keys.Return }),
            };
        }

        public IEnumerable<Command> Commands => commands;
    }
}