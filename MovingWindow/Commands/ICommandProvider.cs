using System.Collections.Generic;

namespace MovingWindow.Commands
{
    internal interface ICommandProvider
    {
        IEnumerable<Command> Commands { get; }
    }
}