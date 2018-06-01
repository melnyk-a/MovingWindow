using MovingWindow.Movements;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovingWindow.Commands.DirectionCommands
{
    internal sealed class LeftDirectionCommand : ChangeDirectionCommand
    {
        public LeftDirectionCommand(IDirectionManager directionManager, IEnumerable<Keys> keys) : 
            base(directionManager, keys)
        {
        }

        public override void Execute()
        {
            directionManager.Direction = Directions.Left;
        }
    }
}