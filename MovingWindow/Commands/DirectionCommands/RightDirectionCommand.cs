using MovingWindow.Movements;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovingWindow.Commands.DirectionCommands
{
    internal sealed class RightDirectionCommand : ChangeDirectionCommand
    {
        public RightDirectionCommand(IDirectionManager directionManager, IEnumerable<Keys> keys) :
            base(directionManager, keys)
        {
        }

        public override void Execute()
        {
            directionManager.Direction = Directions.Right;
        }
    }
}