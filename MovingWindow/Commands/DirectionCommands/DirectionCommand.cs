using MovingWindow.Movements;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovingWindow.Commands.DirectionCommands
{
    internal abstract class ChangeDirectionCommand : Command
    {
        protected IDirectionManager directionManager;

        public ChangeDirectionCommand(IDirectionManager directionManager, IEnumerable<Keys> keys) :
            base(keys)
        {
            this.directionManager = directionManager;
        }
    }
}