using System.Collections.Generic;
using System.Windows.Forms;

namespace MovingWindow.Commands
{
    internal abstract class Command : ICommand
    {
        private readonly IEnumerable<Keys> keys;

        public Command(IEnumerable<Keys> keys)
        {
            this.keys = keys;
        }

        public bool CanExecute(Keys key)
        {
            bool canExecute = false;

            foreach (Keys current in keys)
            {
                if (current == key)
                {
                    canExecute = true;
                    break;
                }
            }

            return canExecute;
        }

        public abstract void Execute();
    }
}