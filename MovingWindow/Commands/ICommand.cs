using System.Windows.Forms;

namespace MovingWindow.Commands
{
    internal interface ICommand
    {
        bool CanExecute(Keys key);
        void Execute();
    }
}