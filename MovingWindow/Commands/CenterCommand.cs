using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MovingWindow.Commands
{
    internal sealed class CenterCommand : Command
    {
        private readonly Form form;

        public CenterCommand(Form form, IEnumerable<Keys> keys) :
            base(keys)
        {
            this.form = form;
        }

        public override void Execute()
        {
            Screen screen = Screen.FromControl(form);

            Rectangle workingArea = screen.WorkingArea;
            form.Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - form.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - form.Height) / 2)
            };
        }
    }
}